using System.Drawing;

namespace Slang.IDE.Shared.Helpers
{
    public static class ColourHelper
    {
        public static Color IntToColour(int rgb)
        {
            return Color.FromArgb(255, (byte)(rgb >> 16), (byte)(rgb >> 8), (byte)rgb);
        }
    }
}
