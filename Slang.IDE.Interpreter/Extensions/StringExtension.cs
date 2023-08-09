using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slang.IDE.Interpreter.Extensions
{
    public static class StringExtension
    {
        public static bool IsNumeric(this string source)
        {
            if(int.TryParse(source, out var result))
            {
                return true;
            }

            return false;
        }
    }
}
