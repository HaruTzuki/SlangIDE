using Slang.IDE.Themes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Slang.IDE.Views
{
    /// <summary>
    /// Interaction logic for WinStartup.xaml
    /// </summary>
    public partial class WinStartup : Window
    {
        public WinStartup()
        {
            InitializeComponent();
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }


        private void btnLightTheme_Click(object sender, RoutedEventArgs e)
        {
            AppTheme.ChangeTheme(Theme.Light);
        }

        private void btnDarkTheme_Click(object sender, RoutedEventArgs e)
        {
            AppTheme.ChangeTheme(Theme.Dark);
        }
    }
}
