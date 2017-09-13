using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Formatting;
using Newtonsoft.Json;

namespace Elasticsearch.Client.Generator
{
    internal class Generator: IDisposable
    {
        private const string ClassName = "ElasticsearchClient";
        private const string Parameters = "Parameters";
        private const string CommonFile = "_common.json";
        private static readonly string[] BodyTypes;
        private static readonly string[] Usings;
        private readonly Workspace mWorkspace;
        private readonly string mInputPath;
        private readonly string mOutputPath;

        static Generator()
        {
            BodyTypes = new[]
            {
                "Stream",
                "byte[]",
                "string"
            };
            Usings = new[]
            {
                "System",
                "System.IO",
                //"System.Net",
                "System.Net.Http",
                "System.Threading.Tasks"
            };
        }

        public Generator(string inputPath, string outputPath)
        {
            mInputPath = inputPath;
            mOutputPath = outputPath;
            mWorkspace = new AdhocWorkspace();
        }

        public void Generate()
        {            
            var common = ReadFile(Path.Combine(mInputPath, CommonFile));
            var directory = new DirectoryInfo(mInputPath);
            foreach (var fileInfo in directory.EnumerateFiles("*.json"))
            {
                if(fileInfo.Name.Equals(CommonFile, StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }
                GenerateFromFile(fileInfo.FullName, mOutputPath, common.UrlParams);
            }
        }

        private void GenerateFromFile(string inputFile, string outputPath, IEnumerable<RestParameter> commonParams)
        {
            if (!Directory.Exists(outputPath))
            {
                Directory.CreateDirectory(outputPath);
            }
            RestMethod description = ReadFile(inputFile);
            description.UrlParams.AddRange(commonParams);
            GenerateCode(description, outputPath);
        }

        private static RestMethod ReadFile(string inputFile)
        {
            using (var sr = File.OpenText(inputFile))
            {
                using (var reader = new JsonTextReader(sr))
                {
                    while (reader.Read())
                    {
                        if (reader.TokenType == JsonToken.PropertyName)
                        {
                            return RestReader.ReadMethod(reader);
                        }
                    }
                }
            }
            throw new InvalidDataException("Input file must contain some json.");
        }

        private static NamespaceDeclarationSyntax GetNamespace()
        {
            return SyntaxFactory.NamespaceDeclaration(
                //todo just use identifier name?
                SyntaxFactory.QualifiedName(
                    SyntaxFactory.IdentifierName("Elasticsearch"),
                    SyntaxFactory.IdentifierName("Client")));
        }

        private static ClassDeclarationSyntax GetParameterClass(string name, string helpLink)
        {
            var trivia = SyntaxFactory.TriviaList(GetDocumentationComment(helpLink));
            return SyntaxFactory.ClassDeclaration(name)
                .WithModifiers(SyntaxFactory.TokenList(SyntaxFactory.Token(SyntaxKind.PublicKeyword)))
                .WithBaseList(SyntaxFactory.BaseList(
                    SyntaxFactory.SimpleBaseType(SyntaxFactory.IdentifierName(Parameters))
                        .AsSeparatedList<BaseTypeSyntax>()))
                        .WithLeadingTrivia(trivia);
        }

        private static ClassDeclarationSyntax GetApiClass()
        {
            return SyntaxFactory.ClassDeclaration(ClassName)
                .WithModifiers(SyntaxFactory.TokenList(
                    SyntaxFactory.Token(SyntaxKind.PublicKeyword),
                    SyntaxFactory.Token(SyntaxKind.PartialKeyword)));
        }

        private void GenerateCode(RestMethod description, string outputPath)
        {
            if (description == null)
            {
                throw new ArgumentNullException(nameof(description));
            }
            var className = GetMethodName(description.Name);
            string paramClassName = null;
            if (description.UrlParams.Count > 0)
            {
                paramClassName = className + Parameters;
                var paramMethods = GenerateParameterMethods(paramClassName, description).ToArray();
                var paramFile = Path.Combine(outputPath, paramClassName + ".cs");
                var paramClass = GetParameterClass(paramClassName, description.DocumentationLink).AddMembers(paramMethods);
                WriteClass(paramClass, paramFile, Enumerable.Empty<string>());
            }
            var file = Path.Combine(outputPath, className + ".cs");
            var methods = GenerateMethods(className, description, paramClassName).ToArray();
            var apiClass = GetApiClass().AddMembers(methods);
            WriteClass(apiClass, file, Usings);
        }

        private void WriteClass(ClassDeclarationSyntax classSyntax, string fileName, IEnumerable<string> usings)
        {                      
            var unit = SyntaxFactory.CompilationUnit()
                .WithUsings(SyntaxFactory.List(usings
                    .Select(u => SyntaxFactory.UsingDirective(SyntaxFactory.IdentifierName(u)))))
                .AddMembers(GetNamespace()
                    .AddMembers(classSyntax));
            var node = Formatter.Format(unit, mWorkspace);
            using (var tw = File.CreateText(fileName))
            {
                node.WriteTo(tw);
            }
        }

        private static IEnumerable<MemberDeclarationSyntax> GenerateParameterMethods(string className,
            RestMethod description)
        {
            HashSet<string> knownParams = new HashSet<string>();
            foreach (var parameter in description.UrlParams)
            {
                var paramKey = $"{parameter.Name}.{parameter.Type}";
                if (knownParams.Contains(paramKey))
                {
                    continue;
                }
                else
                {
                    knownParams.Add(paramKey);
                }
                var statements = new List<StatementSyntax>();   
                SyntaxKind paramType;
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
                        paramType = SyntaxKind.StringKeyword;
                        break;
                    case "boolean":
                        paramType = SyntaxKind.BoolKeyword;
                        break;
                    case "number":
                        paramType = SyntaxKind.LongKeyword;
                        break;
                    case "integer":
                        paramType = SyntaxKind.IntKeyword;
                        break;
                    case "float":
                        paramType = SyntaxKind.DoubleKeyword;
                        break;
                    default:
                        throw new InvalidDataException("Unknown parameter type " + parameter.Type);
                }
                var type = SyntaxFactory.PredefinedType(SyntaxFactory.Token(paramType));
                var parameterDeclaration = SyntaxFactory.Parameter(SyntaxFactory.Identifier("value"))
                    .WithType(type);
                var parameters = new List<ParameterSyntax>
                {
                    parameterDeclaration
                };
                var valueRef = SyntaxFactory.IdentifierName("value");
                ExpressionSyntax valueExpression = valueRef;
                if (paramType == SyntaxKind.BoolKeyword)
                {
                    valueExpression = valueRef.Invoke("ToString").Invoke("ToLower");
                }
                var arguments = new List<ArgumentSyntax>
                {
                    SyntaxFactory.Argument(parameter.Name.AsLiteralExpression()),
                    SyntaxFactory.Argument(valueExpression)
                };
                statements.Add(SyntaxFactory.ExpressionStatement(
                    SyntaxFactory.InvocationExpression("SetValue".AsIdentifierName(),
                        arguments.AsArgumentList())));
                statements.Add(SyntaxFactory.ReturnStatement(SyntaxFactory.ThisExpression()));
                var trivia = SyntaxFactory.TriviaList(
                    GetSummaryComment(parameter.Description),
                    GetParameterTrivia(parameter));
                var modifiers = new []
                {
                    SyntaxFactory.Token(SyntaxKind.PublicKeyword),
                    SyntaxFactory.Token(SyntaxKind.VirtualKeyword)
                };
                yield return SyntaxFactory.MethodDeclaration(
                    SyntaxFactory.ParseTypeName(className),
                    SyntaxFactory.Identifier(parameter.Name))
                    .WithModifiers(modifiers.AsTokenList())
                    .WithBody(statements.AsBlock())
                    .WithParameterList(parameters.AsParameterList())
                    .WithLeadingTrivia(trivia);
            }
        }

        private static IEnumerable<MemberDeclarationSyntax> GenerateMethods(string baseName, RestMethod description,
            string parameterType = null)
        {
            var methods = new List<MemberDeclarationSyntax>();
            HashSet<string> signatures = new HashSet<string>();
            foreach (var urlPath in description.UrlPaths)
            {
                var dict = new SortedDictionary<int, RestParameter>();
                foreach (var urlPart in description.UrlParts)
                {
                    var index = urlPath.IndexOf(urlPart.Name, StringComparison.OrdinalIgnoreCase);
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
                        var newMethodName = baseName + ToCamelCase(httpMethod.ToLower());
                        return GenerateOverloads(newMethodName, httpMethod, urlPath, parts, description, parameterType);
                    }));
                }
            }
            return methods;
        }

        private static IEnumerable<MemberDeclarationSyntax> GenerateOverloads(string methodName, string httpMethod,
            string urlPath,
            IList<RestParameter> urlParts, RestMethod description, string parameterType = null)
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
                        GenerateMethod(methodName, docLink, httpMethod, urlPath, urlParts, body, bodyType, parameterType,
                            true);
                }
            }
        }

        private static MemberDeclarationSyntax NoBody(string name, string docLink, string httpMethod, string uri,
            IList<RestParameter> urlParts, string parameterType, bool async = false)
        {
            return GenerateMethod(name, docLink, httpMethod, uri, urlParts, null, null, parameterType, async);
        }

        private static MemberDeclarationSyntax GenerateMethod(string name, string docLink, string httpMethod, string uri,
            IList<RestParameter> urlParts, RestParameter body, string bodyType, string parameterType = null,
            bool async = false)
        {
            string disamb = string.Empty;
            if (body != null && bodyType == "string")
            {
                disamb = "String";
            }
            name += disamb;
            //start collections for doc comments and parameters.
            var methodParams = new List<ParameterSyntax>();
            var methodDocs = new List<SyntaxTrivia>
            {
                GetDocumentationComment(docLink)
            };
            var methodStatements = new List<StatementSyntax>();
            //get arguments to pass into the string format call which computes the uri.                         
            var uriArguments = new ArgumentSyntax[urlParts.Count + 1];
            for (var i = 0; i < urlParts.Count; i++)
            {
                var urlPart = urlParts[i];
                //add param comment to method.
                methodDocs.Add(GetParameterCommentStatement(urlPart.Name, urlPart.Description));
                //add parameter to method.
                SyntaxKind urlPathType;
                switch (urlPart.Type)
                {
                    case "list":
                    case "string":
                        urlPathType = SyntaxKind.StringKeyword;
                        break;
                    case "number":
                        urlPathType = SyntaxKind.LongKeyword;
                        break;
                    default:
                        throw new InvalidDataException("Unknown parameter type " + urlPart.Type);
                }
                methodParams.Add(SyntaxFactory.Parameter(SyntaxFactory.Identifier(urlPart.Name))
                    .WithType(SyntaxFactory.PredefinedType(SyntaxFactory.Token(urlPathType))));
                //mutate the format string and add parameters to the string.format call.
                uri = uri.Replace(urlPart.Name, i.ToString());
                uriArguments[i + 1] = SyntaxFactory.Argument(SyntaxFactory.IdentifierName(urlPart.Name));
            }
            ExpressionSyntax uriInitializer;
            if (urlParts.Count == 0)
            {
                uriInitializer = uri.AsLiteralExpression();
            }
            else
            {
                //todo replace with string interpolation
                uriArguments[0] = SyntaxFactory.Argument(uri.AsLiteralExpression());
                uriInitializer = SyntaxFactory.InvocationExpression(
                    SyntaxFactory.MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression,
                        SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.StringKeyword)),
                        SyntaxFactory.IdentifierName("Format")))
                    .WithArgumentList(SyntaxFactory.ArgumentList(SyntaxFactory.SeparatedList(
                        uriArguments)));
            }
            //add the uri statement to the body first.
            var setUri = SyntaxFactory.VariableDeclaration(SyntaxFactory.IdentifierName("var"))
                .WithVariables(SyntaxFactory.VariableDeclarator("uri")
                    .WithInitializer(SyntaxFactory.EqualsValueClause(uriInitializer))
                    .AsSeparatedList());
            methodStatements.Add(SyntaxFactory.LocalDeclarationStatement(setUri));
            //return the result of the execute method
            var executeArgs = new List<ArgumentSyntax>
            {
                SyntaxFactory.Argument(SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression,
                    SyntaxFactory.Literal(httpMethod))),
                SyntaxFactory.Argument(SyntaxFactory.IdentifierName("uri"))
            };
            if (body != null)
            {
                //add method parameter for the body type and pass the reference to the execute method.
                const string bodyVariable = "body";
                var paramDeclare = SyntaxFactory.Parameter(SyntaxFactory.Identifier(bodyVariable))
                    .WithType(SyntaxFactory.ParseTypeName(bodyType));
                methodParams.Add(paramDeclare);
                methodDocs.Add(GetParameterCommentStatement(body.Name, body.Description));
                executeArgs.Add(SyntaxFactory.Argument(SyntaxFactory.IdentifierName(bodyVariable)));
            }
            //get statements which add optional uri parameters to the rest call
            if (parameterType != null)
            {
                //add method parameter for the parameter setter function;
                var funcType = SyntaxFactory.GenericName(SyntaxFactory.Identifier("Func"),
                    SyntaxFactory.TypeArgumentList(SyntaxFactory.SeparatedList<TypeSyntax>(
                        new[]
                        {
                            SyntaxFactory.IdentifierName(parameterType),
                            SyntaxFactory.IdentifierName(parameterType)
                        })));
                const string options = "options";
                methodParams.Add(SyntaxFactory.Parameter(SyntaxFactory.Identifier(options))
                    .WithType(funcType)
                    .WithDefault(SyntaxFactory.EqualsValueClause(SyntaxFactory.LiteralExpression(
                        SyntaxKind.NullLiteralExpression))));
                methodDocs.Add(GetParameterCommentStatement(options,
                    "The function to set optional url parameters."));
                //create the params object and pass it to the function.
                var ifStatement = SyntaxFactory.IfStatement(SyntaxFactory.BinaryExpression(
                    SyntaxKind.NotEqualsExpression, SyntaxFactory.IdentifierName(options),
                    SyntaxFactory.LiteralExpression(SyntaxKind.NullLiteralExpression)),
                    SyntaxFactory.Block(SyntaxFactory.SingletonList<StatementSyntax>(
                        SyntaxFactory.ExpressionStatement(
                            SyntaxFactory.AssignmentExpression(
                                SyntaxKind.SimpleAssignmentExpression,
                                SyntaxFactory.IdentifierName("uri"),
                                SyntaxFactory.InvocationExpression(
                                    SyntaxFactory.MemberAccessExpression(
                                        SyntaxKind.SimpleMemberAccessExpression,
                                        SyntaxFactory.InvocationExpression(
                                            SyntaxFactory.MemberAccessExpression(
                                                SyntaxKind.SimpleMemberAccessExpression,
                                                SyntaxFactory.IdentifierName(options),
                                                SyntaxFactory.IdentifierName("Invoke")))
                                            .WithArgumentList(SyntaxFactory.Argument(
                                                SyntaxFactory.ObjectCreationExpression(
                                                    SyntaxFactory.IdentifierName(parameterType))
                                                    .WithArgumentList(SyntaxFactory.ArgumentList()))
                                                .AsArgumentList()),
                                        SyntaxFactory.IdentifierName("GetUri")))
                                    .WithArgumentList(SyntaxFactory.Argument(
                                        SyntaxFactory.IdentifierName("uri")).AsArgumentList()))))));
                methodStatements.Add(ifStatement);
            }
            //add return statement
            var executeRef = SyntaxFactory.MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression,
                SyntaxFactory.IdentifierName("mConnection"),
                async ? SyntaxFactory.IdentifierName("ExecuteAsync") : SyntaxFactory.IdentifierName("Execute"));
            if (async)
            {
                methodStatements.Add(SyntaxFactory.ReturnStatement(SyntaxFactory.AwaitExpression(
                    SyntaxFactory.InvocationExpression(executeRef,
                        SyntaxFactory.ArgumentList(SyntaxFactory.SeparatedList(executeArgs))))));
            }
            else
            {
                methodStatements.Add(SyntaxFactory.ReturnStatement(
                    SyntaxFactory.InvocationExpression(executeRef,
                        SyntaxFactory.ArgumentList(SyntaxFactory.SeparatedList(executeArgs)))));
            }
            return async
                ? GetAsyncApiMethod(name, methodDocs, methodStatements, methodParams)
                : GetSyncApiMethod(name, methodDocs, methodStatements, methodParams);
        }

        private static MethodDeclarationSyntax GetAsyncApiMethod(string name, 
            IList<SyntaxTrivia> trivia, IList<StatementSyntax> statements, IList<ParameterSyntax> parameters)
        {
            return SyntaxFactory.MethodDeclaration(SyntaxFactory.GenericName(SyntaxFactory.Identifier("Task"),
                SyntaxFactory.TypeArgumentList(
                    SyntaxFactory.SingletonSeparatedList<TypeSyntax>(
                        SyntaxFactory.IdentifierName("HttpResponseMessage")))),
                SyntaxFactory.Identifier(name + "Async"))
                .WithParameterList(SyntaxFactory.ParameterList(SyntaxFactory.SeparatedList(parameters)))
                .WithBody(SyntaxFactory.Block(statements))
                .WithModifiers(SyntaxFactory.TokenList(
                    SyntaxFactory.Token(SyntaxKind.PublicKeyword),
                    SyntaxFactory.Token(SyntaxKind.AsyncKeyword)))
                .WithLeadingTrivia(trivia);
        }

        private static MethodDeclarationSyntax GetSyncApiMethod(string name,
            IList<SyntaxTrivia> trivia, IList<StatementSyntax> statements, IList<ParameterSyntax> parameters)
        {
            return SyntaxFactory.MethodDeclaration(SyntaxFactory.IdentifierName("HttpResponseMessage"),
                SyntaxFactory.Identifier(name))
                .WithParameterList(SyntaxFactory.ParameterList(SyntaxFactory.SeparatedList(parameters)))
                .WithBody(SyntaxFactory.Block(statements))
                .WithModifiers(SyntaxFactory.TokenList(
                    SyntaxFactory.Token(SyntaxKind.PublicKeyword)))
                .WithLeadingTrivia(trivia);
        }

        private static string GetMethodName(string name)
        {
            //todo use regex, but who likes regex...
            var methodName = name.Replace("_", " ").Replace(".", " ");
            methodName = ToCamelCase(methodName).Replace(" ", string.Empty);
            return methodName;
        }

        private static SyntaxTrivia GetSummaryComment(string summary)
        {
            return SyntaxFactory.Comment($"///<summary>{summary.XmlEscape()}</summary>{Environment.NewLine}");
        }

        private static SyntaxTrivia GetDocumentationComment(string documentationLink)
        {
            return SyntaxFactory.Comment($"///<summary><see href=\"{documentationLink}\"/></summary>{Environment.NewLine}");
        }

        private static SyntaxTrivia GetParameterTrivia(RestParameter parameter)
        {
            var paramDescription = "";
            if (parameter.Options != null && parameter.Options.Count > 0)
            {
                paramDescription += $"<para>Options: {string.Join(",", parameter.Options)}</para>";
            }
            if (parameter.Default != null)
            {
                paramDescription += $"<para>Default: {parameter.Default}</para>";
            }
            return SyntaxFactory.Comment($"///<param name=\"value\">{paramDescription}</param>{Environment.NewLine}");
        }

        private static SyntaxTrivia GetParameterCommentStatement(string parameter, string description)
        {
            return SyntaxFactory.Comment($"///<param name=\"{parameter}\">{description.XmlEscape()}</param>{Environment.NewLine}");
        }

        private static string ToCamelCase(string input)
        {
            var tokens = input.Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);
            for (var i = 0; i < tokens.Length; i++)
            {
                var token = tokens[i];
                tokens[i] = token.Substring(0, 1).ToUpper() + token.Substring(1);
            }
            return string.Join(" ", tokens);
        }

        public void Dispose()
        {
            mWorkspace.Dispose();
        }
    }
}