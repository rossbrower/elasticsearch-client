using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Elasticsearch.Client.Generator
{
    public static class Extensions
    {
        public static SeparatedSyntaxList<TItem> AsSeparatedList<TItem>(this TItem item) 
            where TItem : SyntaxNode
        {
            return SyntaxFactory.SingletonSeparatedList(item);
        }

        public static SeparatedSyntaxList<TBase> AsSeparatedList<TItem, TBase>(this TItem item) 
            where TItem : SyntaxNode, TBase where TBase : SyntaxNode
        {
            return SyntaxFactory.SingletonSeparatedList<TBase>(item);
        }

        public static SyntaxList<TItem> AsList<TItem>(this TItem item)
            where TItem : SyntaxNode
        {
            return SyntaxFactory.SingletonList(item);
        }

        public static SyntaxList<TBase> AsList<TItem, TBase>(this TItem item)
            where TItem : SyntaxNode, TBase where TBase : SyntaxNode
        {
            return SyntaxFactory.SingletonList<TBase>(item);
        }

        public static SyntaxTokenList AsTokenList(this SyntaxToken token)
        {
            return SyntaxFactory.TokenList(token);
        }

        public static SyntaxTokenList AsTokenList(this IEnumerable<SyntaxToken> tokens)
        {
            return SyntaxFactory.TokenList(tokens);
        }

        public static ParameterListSyntax AsParameterList(this IEnumerable<ParameterSyntax> parameters)
        {
            return SyntaxFactory.ParameterList(SyntaxFactory.SeparatedList(parameters));
        }

        public static ParameterListSyntax AsParameterList(this ParameterSyntax parameter)
        {
            return SyntaxFactory.ParameterList(SyntaxFactory.SingletonSeparatedList(parameter));
        }

        public static ArgumentListSyntax AsArgumentList(this IEnumerable<ArgumentSyntax> arguments)
        {
            return SyntaxFactory.ArgumentList(SyntaxFactory.SeparatedList(arguments));
        }

        public static ArgumentListSyntax AsArgumentList(this ArgumentSyntax argument)
        {
            return SyntaxFactory.ArgumentList(SyntaxFactory.SingletonSeparatedList(argument));
        }

        public static BlockSyntax AsBlock(this IEnumerable<StatementSyntax> statements)
        {
            return SyntaxFactory.Block(statements);
        }

        public static IdentifierNameSyntax AsIdentifierName(this string name)
        {
            return SyntaxFactory.IdentifierName(name);
        }

        public static SyntaxToken AsIdentifier(this string name)
        {
            return SyntaxFactory.Identifier(name);
        }

        public static SyntaxToken AsLiteral(this string str)
        {
            return SyntaxFactory.Literal(str);
        }

        public static ExpressionSyntax AsLiteralExpression(this string str)
        {
            return SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression, str.AsLiteral());
        }

        public static InvocationExpressionSyntax Invoke(this ExpressionSyntax member, string method)
        {
            return SyntaxFactory.InvocationExpression(
                SyntaxFactory.MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression,
                    member, SyntaxFactory.IdentifierName(method)));
        }

        public static string XmlEscape(this string str)
        {
            return new System.Xml.Linq.XText(str).ToString();
        }
    }
}
