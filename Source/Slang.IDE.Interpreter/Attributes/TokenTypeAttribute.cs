namespace Slang.IDE.Interpreter.Attributes
{
    internal class TokenTypeAttribute : Attribute
    {
        public string Token;

        public TokenTypeAttribute(string token)
        {
            Token = token;
        }
    }
}