﻿using IDE.Helper;
using IDE.Helper.Custom;

namespace IDE.Views
{
    public partial class FrmSplashScreen : SlangIDEForm
    {
        private readonly string[] _args;

        public FrmSplashScreen(string[] args)
        {
            InitializeComponent();


            _args = args;
        }

        private async void FrmSplashScreen_Shown(object sender, EventArgs e)
        {
            await Task.Delay(5000);
            if (_args.Length > 0)
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
            Functions.LoadProject(_args[0]);
            var form = new FrmMain();
            this.Hide();
            form.ShowDialog();
            return Task.CompletedTask;
        }

        private Task OpenFromApp()
        {
            var form = new FrmStartup();
            this.Hide();
            form.ShowDialog();
            return Task.CompletedTask;
        }
    }
}
