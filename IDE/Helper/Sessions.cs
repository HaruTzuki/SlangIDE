using IDE.Preferences;
using Slang.IDE.Shared.IDE;
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
        public static List<Breakpoint> Breakpoints { get; set; } = new List<Breakpoint>();
        public static List<Bookmark> Bookmarks { get; set; } = new List<Bookmark>();
    }
}
