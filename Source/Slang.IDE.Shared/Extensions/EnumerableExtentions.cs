using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Slang.IDE.Shared.Extensions
{
    public static class EnumerableExtentions
    {
        public static bool IsIn<TSource>(this TSource source, params TSource[] options)
        {
            return options.Contains(source);
        }
    }
}
