using IDE.Helper;
using IDE.Preferences;
using IDE.Properties;
using Newtonsoft.Json;

namespace IDE.Views
{
    public partial class FrmStartup : Form
    {
        public FrmStartup()
        {
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            InitializeComponent();

            LoadRecent();
        }

        private void LoadRecent()
        {
            var projects = Functions.LoadRecent();

            foreach (var project in projects.OrderBy(x => x.Date))
            {
                var btn = new Button
                {
                    Name = $"Btn_{project.Name.Replace(" ", "_")}",
                    Text = $"{project.Name}",
                    Height = 100,
                    FlatStyle = FlatStyle.Flat,
                    Dock = DockStyle.Top
                };
                btn.FlatAppearance.BorderSize = 0;
                btn.TextAlign = ContentAlignment.MiddleLeft;
                btn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
                btn.Tag = project;
                btn.Click += RecentProjectClick;

                this.recentProjectPanel.Controls.Add(btn);
                this.recentProjectPanel.Padding = new Padding(10);
            }
        }

        private void RecentProjectClick(object? sender, EventArgs e)
        {
            var project = (sender as Button)?.Tag as RecentProject;
            Functions.LoadProject(project!.Path);
            Functions.UpdateRecendProject(project);

            var form = new FrmMain();
            this.Hide();
            form.ShowDialog();
        }

        private void BtnNewProject_Click(object sender, EventArgs e)
        {
            var form = new FrmProjectsList();
            this.Hide();
            form.ShowDialog();
        }

        private void BtnLoadSlangProject_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog
            {
                Filter = "Slag Project|*.slangproject",
                Title = "Open Slang Project"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Functions.LoadProject(ofd.FileName);
                var form = new FrmMain();
                this.Hide();
                form.ShowDialog();
            }

        }

        private void FrmStartup_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
