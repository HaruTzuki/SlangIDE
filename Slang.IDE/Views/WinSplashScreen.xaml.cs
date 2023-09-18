using Slang.IDE.Cache;
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
    /// Interaction logic for WinSplashScreen.xaml
    /// </summary>
    public partial class WinSplashScreen : Window
    {
        private readonly string[] _args;

        public WinSplashScreen(string[] args)
        {
            InitializeComponent();
            _args = args;
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            await Task.Delay(1);

            // Create Database and Tables
            //var sqlite = new Dblite();
            //sqlite.CreateModel();

            if(_args.Length > 0)
            {
                await OpenFromFile();
            }
            else
            {
                await OpenFromApp();
            }
        }

        private Task OpenFromFile()
        {
            return Task.CompletedTask;
        }

        private Task OpenFromApp()
        {
            var window = new WinStartup();
            this.Hide();
            window.ShowDialog();
            return Task.CompletedTask;
        }
    }
}
