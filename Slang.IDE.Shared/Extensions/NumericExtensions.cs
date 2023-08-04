using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slang.IDE.Shared.Extensions
{
    public static class NumericExtensions
    {
        public static int AsInt(this object source)
        {
            try
            {
                var result = Convert.ToInt32(source);
                return result;
            }
            catch
            {
                return default;
            }
        }
    }
}
