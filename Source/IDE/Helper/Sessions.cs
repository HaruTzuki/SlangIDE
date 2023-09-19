using IDE.Preferences;
using Slang.IDE.Shared.IDE;

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
