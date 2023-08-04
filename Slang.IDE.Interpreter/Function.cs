using Slang.IDE.Interpreter.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slang.IDE.Interpreter
{
    public class Function
    {
        public string Identifier { get; set; }
        public Parameter[] Parameters { get; set; }
        public Tokens ReturnDataType { get; set; }
    }
}
