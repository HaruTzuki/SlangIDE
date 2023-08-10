using Slang.IDE.Interpreter.Enumeration;

namespace Slang.IDE.Interpreter
{
    public class Function
    {
        public string Identifier { get; set; }
        public Parameter[] Parameters { get; set; }
        public Tokens ReturnDataType { get; set; }
    }
}
