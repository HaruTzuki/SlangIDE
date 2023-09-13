using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDE.Helper
{
    [EditorBrowsable(EditorBrowsableState.Always)]
    internal abstract class Features
    {
        internal static bool BreakpointEnable = false;
        internal static bool BookmarkEnable = true;
        internal static bool DebugMode = false;
    }
}
