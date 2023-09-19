using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Slang.IDE.Themes
{
    public class AppTheme
    {
        public static void ChangeTheme(Theme themeType)
        {
            ResourceDictionary theme = new ResourceDictionary() { Source = new Uri($"Themes/{themeType}.xaml", UriKind.Relative)};

            App.Current.Resources.Clear();
            App.Current.Resources.MergedDictionaries.Add(theme);
        }
    }

    public enum Theme
    {
        Light = 0,
        Dark = 1,
    }

}
