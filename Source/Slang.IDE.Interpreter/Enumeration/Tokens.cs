using Slang.IDE.Interpreter.Attributes;
using Slang.IDE.Interpreter.Extensions;

namespace Slang.IDE.Interpreter.Enumeration
{
    public enum Tokens
    {
        [TokenType("int")]
        INTEGER,
        [TokenType("string")]
        STRING,
        [TokenType("bool")]
        BOOLEAN,
        [TokenType("float")]
        FLOAT,
        [TokenType("void")]
        VOID,
        [TokenType("fn")]
        FUNCTION,
        [TokenType(";")]
        SEMICOLON,
        [TokenType("(")]
        LPARENTHENSIS,
        [TokenType(")")]
        RPARENTHENSIS,
        [TokenType("{")]
        LCURLY,
        [TokenType("}")]
        RCURLY,
        [TokenType(",")]
        COMMA,
        [TokenType(":")]
        COLON,
        USERDEFINED
    }

    internal static class InternalLists
    {
        internal static readonly string[] _Tokens = new string[]
        {
            Tokens.INTEGER.GetTokenType(),
            Tokens.STRING.GetTokenType(),
            Tokens.BOOLEAN.GetTokenType(),
            Tokens.FLOAT.GetTokenType(),
            Tokens.VOID.GetTokenType(),
            Tokens.FUNCTION.GetTokenType(),
            Tokens.SEMICOLON.GetTokenType(),
            Tokens.COMMA.GetTokenType(),
            Tokens.COLON.GetTokenType(),
            Tokens.LPARENTHENSIS.GetTokenType(),
            Tokens.RPARENTHENSIS.GetTokenType(),
            Tokens.LCURLY.GetTokenType(),
            Tokens.RCURLY.GetTokenType(),
        };
    }
}
