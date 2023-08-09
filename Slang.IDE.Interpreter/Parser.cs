using Slang.IDE.Interpreter.Collection;
using Slang.IDE.Interpreter.Enumeration;
using Slang.IDE.Interpreter.Extensions;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Slang.IDE.Interpreter
{
    public class Parser
    {
        /// <summary>
        /// Converts the function string e.g. fn add(a:int, b:int):int to object.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static Function Parse(string source)
        {
            return new Function
            {
                Identifier = GetFunctionIdentifier(source),
                Parameters = GetParameters(source),
                ReturnDataType = GetReturnType(source)
            };
        }

        public static bool Parse2(string source)
        {
            var sourceLines = source.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            foreach(var line in sourceLines)
            {
                Debug.WriteLine(line);
            }
            

            return true;
        }

        public static bool Validate(string written)
        {
            if (!Lists.UserDefinedFunctions.Any())
                return false;

            // Get the Identifier
            var identifier = written.Substring(0, written.IndexOf(Tokens.LPARENTHENSIS.GetTokenType()));

            if(!Lists.UserDefinedFunctions.Any(x=>x.Identifier == identifier))
            {
                throw new ArgumentException($"Error: There is not function with name: {identifier}");
            }

            // Get parameters
            var selectedFunction = Lists.UserDefinedFunctions.First(x=>x.Identifier == identifier);
            // Check if function waiting parameters
            if(selectedFunction.Parameters.Any())
            {
                //Get written parameters
                var match = Regex.Match(written, @"\((.*?)\)");
                if(match.Success)
                {
                    var writtenParameters = match.Groups[1].Value;

                    var split = writtenParameters.Split(Tokens.COMMA.GetTokenType());

                    if(split.Length != selectedFunction.Parameters.Length)
                    {
                        throw new ArgumentException("Error: You have not pass the mandantory arguments.");
                    }

                    for(var i = 0; i < split.Length; i++)
                    {
                        if (GetToken(split[i]) != selectedFunction.Parameters[i].DataType)
                        {
                            throw new ArgumentException($"Error: The parameter {split[i]} is not {selectedFunction.Parameters[i].DataType.GetTokenType()}");
                        }
                    }
                }
            }

            return true;
        }

        private static Tokens GetToken(string value)
        {
            if (value.IsNumeric())
            {
                return Tokens.INTEGER;
            }

            return Tokens.USERDEFINED;
        }

        #region Parsing Private Functions
        /// <summary>
        /// Getting the Function Identifier
        /// </summary>
        /// <param name="source">The function string</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">When the format is not correct.</exception>
        private static string GetFunctionIdentifier(string source)
        {
            if (!source.StartsWith("fn"))
            {
                //Is not a function.
                throw new ArgumentException("Is not a function");
            }

            // Find Identifier
            var result = source.Substring(2).Trim();
            var mRet = "";
            // Get the Function Name
            for (var i = 0; i < result.Length; i++)
            {
                if (result[i] == '(')
                    break;

                mRet += result[i];
            }

            return mRet;
        }
        /// <summary>
        /// Getting the Function Parameters
        /// </summary>
        /// <param name="source">The function string</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">When the format is not correct</exception>
        private static Parameter[] GetParameters(string source)
        {
            // Get Parameters
            var match = Regex.Match(source, @"\((.*?)\)");

            if (match.Success)
            {
                var parameterText = match.Groups[1].Value;

                if (!string.IsNullOrEmpty(parameterText))
                {
                    var split = parameterText.Split(Tokens.COMMA.GetTokenType(), StringSplitOptions.RemoveEmptyEntries);
                    var parameters = new List<Parameter>();

                    foreach (var value in split)
                    {
                        var parameterSplit = value.Split(Tokens.COLON.GetTokenType(), StringSplitOptions.RemoveEmptyEntries);

                        if (parameterSplit.Length < 2)
                        {
                            throw new ArgumentException("Error: The function parameters does not have the correct format (identifier:datatype)");
                        }

                        if (InternalLists._Tokens.Contains(parameterSplit[0]))
                        {
                            throw new ArgumentException("Error: The parameter's indentifier cannot have the same name with datatype.");
                        }

                        var parameter = new Parameter();
                        parameter.Identifier = parameterSplit[0].Trim();
                        parameter.DataType = parameterSplit[1].ToToken();
                        parameters.Add(parameter);
                    }


                    return parameters.ToArray();
                }
            }

            return Array.Empty<Parameter>();
        }
        /// <summary>
        /// Getting the Return Type.
        /// </summary>
        /// <param name="source">The function string.</param>
        /// <returns></returns>
        private static Tokens GetReturnType(string source)
        {
            //Get return type
            var indexOfRParenthensis = source.IndexOf(Tokens.RPARENTHENSIS.GetTokenType());

            try
            {
                if (source.Substring(indexOfRParenthensis + 1)[0] == ':')
                {
                    var returnType = source.Substring(indexOfRParenthensis + 2).ToToken();
                    return returnType;
                }
            }
            catch
            {
                return Tokens.VOID;
            }

            return Tokens.VOID;
        } 
        #endregion
    }
}
