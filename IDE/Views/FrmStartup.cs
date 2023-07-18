using IDE.Helper;
using IDE.Helper.Custom;
using IDE.Preferences;
using IDE.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
namespace IDE.Views
{
    public partial class FrmStartup : SlangIDEForm
    {
        public FrmStartup()
        {
            InitializeComponent();
            AllowResizing = false;

            LoadRecent();
        }

        private void LoadRecent()
        {
            var path = Settings.Default["FileFolder"].ToString();
            var filePath = Path.Combine(path, Settings.Default["RecentFile"].ToString());

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "[]");
            }

            using var streamReader = new StreamReader(filePath);
            var projects = JsonConvert.DeserializeObject<IEnumerable<RecentProject>>(streamReader.ReadToEnd());



            foreach (var project in projects.OrderBy(x => x.CreatedOn))
            {
                var btn = new Button
                {
                    Name = $"Btn_{project.Name.Replace(" ", "_")}",
                    Text = $"{project.Name}",
                    Height = 100,
                    FlatStyle = FlatStyle.Flat
                };
                btn.Dock = DockStyle.Top;
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
    }
}
