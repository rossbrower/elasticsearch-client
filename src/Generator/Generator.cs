using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using Microsoft.CSharp;
using Newtonsoft.Json;

namespace Elasticsearch.Client.Generator
{
    public static class Generator
    {
        private const string Namespace = "Elasticsearch.Client";
        private const string ClassName = "ElasticsearchClient";
        private static readonly TextInfo TextInfo;
        private static readonly CodeDomProvider Provider;
        private static readonly CodeNamespaceImport[] Imports;
        private static readonly Type[] BodyTypes;

        static Generator()
        {
            TextInfo = new CultureInfo("en-US", false).TextInfo;
            Provider = new CSharpCodeProvider(); //this should be disposed, but we're in a console app...
            Imports = new[]
            {
                new CodeNamespaceImport("System"), 
                new CodeNamespaceImport("System.IO"),
                new CodeNamespaceImport("System.Net"),
                new CodeNamespaceImport("System.Net.Http"),
                new CodeNamespaceImport("System.Threading.Tasks")
            };
            BodyTypes = new[]
            {
                typeof (Stream),
                typeof (byte[]),
                typeof (string)
            };
        }

        public static void GenerateFromDirectory(string inputPath, string outputPath, string testPath)
        {
            var directory = new DirectoryInfo(inputPath);
            foreach (var fileInfo in directory.EnumerateFiles("*.json"))
            {
                GenerateFromFile(fileInfo.FullName, outputPath);
            }
        }

        public static void GenerateFromFile(string inputFile, string outputPath)
        {
            MethodDescription description = null;
            using (var sr = File.OpenText(inputFile))
            {
                using (var reader = new JsonTextReader(sr))
                {
                    while (reader.Read())
                    {
                        if (reader.TokenType == JsonToken.PropertyName)
                        {
                            description = ReadMethod(reader);
                        }
                    }
                }
            }
            GenerateCode(description, outputPath);
        }

        private static void GenerateCode(MethodDescription description, string outputPath)
        {
            if (description == null)
            {
                throw new ArgumentNullException(nameof(description));
            }
            var fileName = GetMethodName(description.Name);
            string paramClassName = null;
            if (description.UrlParams.Count > 0)
            {
                paramClassName = fileName + "Parameters";
                var paramMethods = GenerateParameterMethods(paramClassName, description).ToArray();
                WriteClass(Namespace, paramClassName, paramMethods, Imports, outputPath, baseType: "Parameters");
            }            
            var methods = GenerateMethods(fileName, description, paramClassName).ToArray();
            WriteClass(Namespace, ClassName, methods, Imports, outputPath, fileName, isPartial: true);
        }

        private static void WriteClass(string @namespace, string className, CodeTypeMember[] members, 
            CodeNamespaceImport[] imports, string outputPath, string fileName = null, 
            string baseType = null, bool isPartial = false)
        {
            if (fileName == null)
            {
                fileName = className;
            }
            var compileUnit = new CodeCompileUnit();
            var namespc = new CodeNamespace(@namespace);
            compileUnit.Namespaces.Add(namespc);
            namespc.Imports.AddRange(imports);
            var clss = new CodeTypeDeclaration(className)
            {
                Attributes = MemberAttributes.Public,
                IsPartial = isPartial
            };
            if (baseType != null)
            {
                clss.BaseTypes.Add(baseType);
            }
            namespc.Types.Add(clss);
            clss.Members.AddRange(members);
            var outputFile = Path.Combine(outputPath, fileName + ".cs");
            using (var tw = File.CreateText(outputFile))
            {
                Provider.GenerateCodeFromCompileUnit(compileUnit, tw, new CodeGeneratorOptions
                {
                    BracingStyle = "C"
                });
            }
        }

        private static IEnumerable<CodeTypeMember> GenerateParameterMethods(string className,
            MethodDescription description)
        {
            foreach (var parameter in description.UrlParams)
            {
                var method = new CodeMemberMethod
                {
                    Name = parameter.Name,
                    ReturnType = new CodeTypeReference(className),
                    Attributes = MemberAttributes.Public                    
                };
                method.Comments.Add(GetSummaryComment(parameter.Description));
                Type paramType;         
                switch (parameter.Type)
                {
                    case null:
                        //todo these seem to be incomplete in the spec.
                        continue;
                    case "text":
                    case "list":
                    case "enum":
                    case "string":
                    case "time":
                    case "duration":
                        paramType = typeof (string);
                        break;
                    case "boolean":
                        paramType = typeof(bool);
                        break;
                    case "number":
                        paramType = typeof (long);
                        break;
                    default:
                        throw new InvalidDataException("Unknown parameter type " + parameter.Type);
                }
                var parameterDeclaration = new CodeParameterDeclarationExpression(paramType, "value");
                method.Parameters.Add(parameterDeclaration);
                var paramDescription = "";
                if (parameter.Options != null && parameter.Options.Count > 0)
                {
                    paramDescription += $"<para>Options: {string.Join(",", parameter.Options)}</para>";
                }
                if (parameter.Default != null)
                {
                    paramDescription += $"<para>Default: {parameter.Default}</para>";
                }
                CodeExpression valueExpression;
                if (paramType == typeof (bool))
                {
                    var inner = new CodeMethodInvokeExpression(
                        new CodeVariableReferenceExpression("value"), "ToString");
                    valueExpression = new CodeMethodInvokeExpression(inner, "ToLower");
                }
                else
                {
                    valueExpression = new CodeVariableReferenceExpression("value");
                }
                method.Comments.Add(GetParameterCommentStatement("value", paramDescription));
                method.Statements.Add(new CodeMethodInvokeExpression(new CodeThisReferenceExpression(), "SetValue",
                    new CodePrimitiveExpression(parameter.Name),
                    valueExpression));
                method.Statements.Add(new CodeMethodReturnStatement(new CodeThisReferenceExpression()));
                yield return method;
            }
        }

        private static IEnumerable<CodeTypeMember> GenerateMethods(string baseName, MethodDescription description, string parameterType = null)
        {
            var methods = new List<CodeMemberMethod>();
            HashSet<string> signatures = new HashSet<string>();
            foreach (var urlPath in description.UrlPaths)
            {
                var dict = new SortedDictionary<int, Parameter>();
                foreach (var urlPart in description.UrlParts)
                {
                    var index = urlPath.IndexOf(urlPart.Name, StringComparison.InvariantCulture);
                    if (index > 0)
                    {
                        dict.Add(index, urlPart);
                    }
                }
                var parts = dict.Values.ToList();
                //disallow overloads where the uri is different but the parameters are the same
                //as this would result in duplicate method signatures.
                var signature = string.Join(",", parts);
                if (signatures.Contains(signature))
                {
                    continue;
                }
                signatures.Add(signature);
                if (description.Methods.Count == 1)
                {
                    var httpMethod = description.Methods[0];
                    methods.AddRange(GenerateOverloads(baseName, httpMethod, urlPath, parts, description, parameterType));
                }
                else
                {
                    methods.AddRange(description.Methods.SelectMany(httpMethod =>
                    {
                        var newMethodName = baseName + httpMethod.ToLower().ToCamelCase();
                        return GenerateOverloads(newMethodName, httpMethod, urlPath, parts, description, parameterType);
                    }));
                }
            }
            return methods;
        }

        private static IEnumerable<CodeMemberMethod> GenerateOverloads(string methodName, string httpMethod,
            string urlPath,
            IList<Parameter> urlParts, MethodDescription description, string parameterType = null)
        {
            var docLink = description.DocumentationLink;
            var body = description.Body;
            if (body == null)
            {
                yield return NoBody(methodName, docLink, httpMethod, urlPath, urlParts, parameterType);
                yield return NoBody(methodName, docLink, httpMethod, urlPath, urlParts, parameterType, true);
            }
            else
            {
                if (!body.Required)
                {
                    yield return NoBody(methodName, docLink, httpMethod, urlPath, urlParts, parameterType);
                    yield return NoBody(methodName, docLink, httpMethod, urlPath, urlParts, parameterType, true);
                }
                foreach (var bodyType in BodyTypes)
                {
                    yield return
                        GenerateMethod(methodName, docLink, httpMethod, urlPath, urlParts, body, bodyType, parameterType);
                    yield return
                        GenerateMethod(methodName, docLink, httpMethod, urlPath, urlParts, body, bodyType, parameterType, true);
                }
            }
        }

        private static CodeMemberMethod NoBody(string name, string docLink, string httpMethod, string uri,
            IList<Parameter> urlParts, string parameterType, bool async = false)
        {
            return GenerateMethod(name, docLink, httpMethod, uri, urlParts, null, null, parameterType, async);
        }

        private static CodeMemberMethod GenerateMethod(string name, string docLink, string httpMethod, string uri, 
            IList<Parameter> urlParts, Parameter body, Type bodyType, string parameterType = null, bool async = false)
        {
            string disamb = string.Empty;
            if (body != null && bodyType == typeof (string))
            {
                disamb = "String";
            }
            name += disamb;
            var method = new CodeMemberMethod
            {
                Name = async ? name + "Async" : name,
                Attributes = MemberAttributes.Public,
                ReturnType = new CodeTypeReference(async ? "async Task<HttpResponseMessage>" : "HttpResponseMessage")
            };
            method.Comments.Add(GetDocumentationComment(docLink));
            //set the uri variable to pass into the execute function.
            var setUri = new CodeVariableDeclarationStatement(typeof(string), "uri");
            method.Statements.Add(setUri);
            CodeExpression uriValueExpression;
            if (urlParts.Count == 0)
            {
                uriValueExpression = new CodePrimitiveExpression(uri);
            }
            else
            {
                var stringTypeRef = new CodeTypeReferenceExpression(typeof (string));
                uriValueExpression = new CodeMethodInvokeExpression(stringTypeRef, "Format",
                    new CodePrimitiveExpression(uri));
            }                        
            setUri.InitExpression = uriValueExpression;            
            //return the result of the execute method
            CodeExpression thisRef;
            if (async)
            {
                thisRef = new CodeVariableReferenceExpression("await this");
            }
            else
            {
                thisRef = new CodeThisReferenceExpression();
            }
            var executeInvoke = new CodeMethodInvokeExpression(thisRef, async ? "ExecuteAsync" : "Execute",
                new CodePrimitiveExpression(httpMethod), new CodeVariableReferenceExpression("uri"));            
            var i = 0;     
            foreach(var urlPart in urlParts)
            {
                //add param comment to method.
                method.Comments.Add(GetParameterCommentStatement(urlPart.Name, urlPart.Description));
                //add parameter to method.
                Type urlPathType;
                switch (urlPart.Type)
                {
                    case "list":
                    case "string":
                        urlPathType = typeof (string);
                        break;
                    default:
                        throw new InvalidDataException("Unknown parameter type " + urlPart.Type);
                }
                method.Parameters.Add(new CodeParameterDeclarationExpression(urlPathType, urlPart.Name));
                //mutate the format string and add parameters to the string.format call.
                uri = uri.Replace(urlPart.Name, i.ToString());
                ((CodeMethodInvokeExpression)uriValueExpression).Parameters[0] = new CodePrimitiveExpression(uri);
                ((CodeMethodInvokeExpression)uriValueExpression).Parameters.Add(new CodeVariableReferenceExpression(urlPart.Name));
                i++;
            }            
            if (body != null)
            {
                //add method parameter for the body type and pass the reference to the execute method.
                const string bodyVariable = "body";
                var paramDeclare = bodyType == typeof (string)
                    ? new CodeParameterDeclarationExpression(bodyType, bodyVariable)
                    : new CodeParameterDeclarationExpression(bodyType.Name, bodyVariable);
                method.Parameters.Add(paramDeclare);
                method.Comments.Add(GetParameterCommentStatement(body.Name, body.Description));
                executeInvoke.Parameters.Add(new CodeVariableReferenceExpression(bodyVariable));
            }
            if (parameterType != null)
            {
                //add method parameter for the parameter setter function;
                var funcType = new CodeTypeReference("Func");
                funcType.TypeArguments.Add(parameterType);
                funcType.TypeArguments.Add(parameterType);
                const string parameters = "parameters";
                const string options = "options";
                method.Parameters.Add(new CodeParameterDeclarationExpression(funcType, options + " = null"));
                method.Comments.Add(GetParameterCommentStatement("options",
                    "The function to set optional url parameters."));
                //create the params object and pass it to the function.
                var nullCheck = new CodeBinaryOperatorExpression(new CodeVariableReferenceExpression("options"),
                    CodeBinaryOperatorType.IdentityInequality, new CodePrimitiveExpression(null));
                var ifStatement = new CodeConditionStatement(nullCheck,
                    new CodeVariableDeclarationStatement(parameterType, parameters,
                        new CodeMethodInvokeExpression(new CodeVariableReferenceExpression(options),
                            "Invoke", new CodeObjectCreateExpression(parameterType))),
                    new CodeAssignStatement(new CodeVariableReferenceExpression("uri"),
                        new CodeMethodInvokeExpression(new CodeVariableReferenceExpression(parameters), "GetUri",
                            new CodeVariableReferenceExpression("uri"))));
                method.Statements.Add(ifStatement);
            }
            method.Statements.Add(new CodeMethodReturnStatement(executeInvoke));
            return method;
        }

        private static MethodDescription ReadMethod(JsonReader reader)
        {
            var method = new MethodDescription
            {
                Name = (string) reader.Value
            };
            while (reader.Read())
            {
                if (reader.TokenType == JsonToken.PropertyName)
                {
                    var property = (string) reader.Value;
                    switch (property)
                    {
                        case "documentation":
                            method.DocumentationLink = reader.ReadAsString();
                            break;
                        case "methods":
                            method.Methods = ReadStringArray(reader).ToList();
                            break;
                        case "paths":
                            method.UrlPaths = ReadStringArray(reader).ToList();
                            break;
                        case "parts":
                            method.UrlParts = ReadParameters(reader).ToList();
                            break;
                        case "params":
                            method.UrlParams = ReadParameters(reader).ToList();
                            break;
                        case "body":
                            method.Body = ReadParameter(reader);
                            break;
                    }
                }
            }
            return method;
        }

        private static IEnumerable<Parameter> ReadParameters(JsonReader reader)
        {
            var depth = reader.Depth;
            reader.Read();
            while (reader.Read() && reader.Depth > depth)
            {
                switch (reader.TokenType)
                {
                    case JsonToken.PropertyName:
                        yield return ReadParameter(reader);
                        break;
                }
            }
        }

        private static Parameter ReadParameter(JsonReader reader)
        {
            var parameter = new Parameter
            {
                Name = (string) reader.Value
            };
            while (reader.Read())
            {
                switch (reader.TokenType)
                {
                    case JsonToken.Null:
                        return null;
                    case JsonToken.PropertyName:
                        var propertyName = (string) reader.Value;
                        switch (propertyName)
                        {
                            case "type":
                                parameter.Type = reader.ReadAsString();
                                break;
                            case "description":
                                parameter.Description = reader.ReadAsString();
                                break;
                            case "required":
                                parameter.Required = reader.ReadAsBoolean().GetValueOrDefault();
                                break;
                            case "options":
                                parameter.Options = ReadStringArray(reader).ToList();
                                break;
                            case "default":
                                parameter.Default = ReadDefaultValue(reader);
                                break;
                            case "serialize":
                                parameter.Serialize = reader.ReadAsString();
                                break;
                        }
                        break;
                    case JsonToken.EndObject:
                        return parameter;
                }
            }
            throw new InvalidDataException("Could not parse Parameter");
        }

        private static object ReadDefaultValue(JsonReader reader)
        {
            bool isArray = false;
            List<string> strings = new List<string>();
            while (reader.Read())
            {
                switch (reader.TokenType)
                {
                    case JsonToken.StartArray:
                        isArray = true;
                        break;
                    case JsonToken.String:
                        if (isArray)
                        {
                            strings.Add((string) reader.Value);
                        }
                        else
                        {
                            return (string) reader.Value;
                        }
                        break;
                    case JsonToken.Boolean:
                        return (bool) reader.Value;
                    case JsonToken.Null:
                        return null;
                    case JsonToken.EndArray:
                        return strings;
                    default:
                        throw new InvalidDataException("Unknown default value type: " + reader.TokenType);
                }
            }
            throw new InvalidDataException("Could not parse default value");
        }

        private static IEnumerable<string> ReadStringArray(JsonReader reader)
        {
            bool isArray = false;
            while (reader.Read())
            {
                switch (reader.TokenType)
                {
                    case JsonToken.StartArray:
                        isArray = true;
                        break;
                    case JsonToken.String:
                        yield return (string) reader.Value;
                        if (!isArray)
                        {
                            yield break;
                        }
                        break;
                    case JsonToken.EndArray:
                        yield break;
                }
            }
        }

        private static string GetMethodName(string name)
        {
            //todo use regex, but who likes regex...
            var methodName = name.Replace("_", " ").Replace(".", " ");
            methodName = methodName.ToCamelCase().Replace(" ", string.Empty);
            return methodName;
        }

        private static CodeCommentStatement GetSummaryComment(string summary)
        {
            return new CodeCommentStatement($"<summary>{summary}</summary>", true);
        }

        private static CodeCommentStatement GetDocumentationComment(string documentationLink)
        {
            return GetSummaryComment($"<see href=\"{documentationLink}\"/>");
        }

        private static CodeCommentStatement GetParameterCommentStatement(string parameter, string description)
        {
            return new CodeCommentStatement($"<param name=\"{parameter}\">{description}</param>", true);
        }

        private static string ToCamelCase(this string input)
        {
            return TextInfo.ToTitleCase(input);
        }

        private class MethodDescription
        {
            public MethodDescription()
            {
                UrlParts = new List<Parameter>();
                UrlParams = new List<Parameter>();                    
            }

            public string Name { get; set; }
            public string DocumentationLink { get; set; }
            public List<string> Methods { get; set; }
            public List<string> UrlPaths { get; set; }
            public List<Parameter> UrlParts { get; set; }
            public List<Parameter> UrlParams { get; set; }
            public Parameter Body { get; set; }
        }

        private class Parameter
        {
            public string Name { get; set; }
            public string Type { get; set; }
            public string Description { get; set; }
            public List<string> Options { get; set; }
            public object Default { get; set; }
            public bool Required { get; set; }
            public string Serialize { get; set; }
        }
    }
}