using IDE.Helper;
using IDE.Helper.Custom;
using IDE.Preferences;
using Slang.IDE.Cache;

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

            // Create Database and Tables
            var sqlite = new Dblite();
            sqlite.CreateModel();


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

            var recentProjects = Functions.LoadRecent().ToList();

            if (recentProjects.Exists(x => x.Path == _args[0]))
            {
                Functions.UpdateRecendProject(recentProjects.First(x => x.Path == _args[0]));
            }
            else
            {
                var recentProject = new RecentProject()
                {
                    Date = DateTime.Now,
                    Name = Sessions.SlangProject.Name,
                    Path = _args[0]
                };

                recentProjects.Add(recentProject);
                Functions.SaveRecent(recentProjects);
            }

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
