using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace Elasticsearch.Client.Generator
{
    public static class RestReader
    {
        public static RestMethod ReadMethod(JsonReader reader)
        {
            var method = new RestMethod
            {
                Name = (string)reader.Value
            };
            while (reader.Read())
            {
                if (reader.TokenType == JsonToken.PropertyName)
                {
                    var property = (string)reader.Value;
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

        private static IEnumerable<RestParameter> ReadParameters(JsonReader reader)
        {
            var parameters = new Dictionary<string, RestParameter>();
            var depth = reader.Depth;
            reader.Read();
            while (reader.Read() && reader.Depth > depth)
            {
                switch (reader.TokenType)
                {
                    case JsonToken.PropertyName:
                        var p = ReadParameter(reader);
                        //last in wins on duplicates...
                        parameters[p.Name] = p;
                        break;
                }
            }
            return parameters.Values;
        }

        private static RestParameter ReadParameter(JsonReader reader)
        {
            var parameter = new RestParameter
            {
                Name = (string)reader.Value
            };
            while (reader.Read())
            {
                switch (reader.TokenType)
                {
                    case JsonToken.Null:
                        return null;
                    case JsonToken.PropertyName:
                        var propertyName = (string)reader.Value;
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
                            strings.Add((string)reader.Value);
                        }
                        else
                        {
                            return (string)reader.Value;
                        }
                        break;
                    case JsonToken.Boolean:
                        return (bool)reader.Value;
                    case JsonToken.Integer:
                        return Convert.ToInt32(reader.Value);
                    case JsonToken.Float:
                        return Convert.ToDouble(reader.Value);
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
                        yield return (string)reader.Value;
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
    }
}
