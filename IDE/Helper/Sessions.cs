using IDE.Preferences;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDE.Helper
{
    public static class Sessions
    {
        public static SlangProject SlangProject { get; set; } = new SlangProject();
        public static string ProjectPath { get; set; } = string.Empty;
    }
}
