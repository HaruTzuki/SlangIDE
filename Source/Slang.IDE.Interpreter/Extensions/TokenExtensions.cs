using Slang.IDE.Interpreter.Attributes;
using Slang.IDE.Interpreter.Enumeration;
using System.Reflection;

namespace Slang.IDE.Interpreter.Extensions
{
    public static class TokenExtensions
    {
        public static string GetTokenType(this Tokens token)
        {
            var type = token.GetType();

            if (type != typeof(Tokens))
            {
                throw new ArgumentException($"The {nameof(token)} is not {nameof(Tokens)}");
            }

            MemberInfo[] memberInfo = type.GetMember(token.ToString());

            if (memberInfo != null && memberInfo.Length > 0)
            {
                object[] attrs = memberInfo[0].GetCustomAttributes(typeof(TokenTypeAttribute), false);

                if (attrs != null && attrs.Length > 0)
                {
                    //Pull out the description value
                    return ((TokenTypeAttribute)attrs[0]).Token;
                }
            }
            //If we have no description attribute, just return the ToString of the enum
            return token.ToString();
        }

        public static Tokens ToToken(this string source)
        {
            var type = typeof(Tokens);

            foreach (var name in Enum.GetNames(type))
            {
                var memberInfo = type.GetMember(name);

                if (memberInfo.Length > 0)
                {
                    var attrs = memberInfo[0].GetCustomAttributes(typeof(TokenTypeAttribute), false);
                    if (attrs.Length > 0)
                    {
                        var description = ((TokenTypeAttribute)attrs[0]).Token;
                        if (description == source)
                        {
                            return (Tokens)Enum.Parse(type, name);
                        }
                    }
                }
            }
            return Tokens.USERDEFINED;
        }
    }
}
