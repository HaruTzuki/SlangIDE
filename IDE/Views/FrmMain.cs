using IDE.Controls;
using IDE.Helper;
using IDE.Helper.Custom;
using IDE.Preferences;
using IDE.Views.AdditionViews;

namespace IDE.Views
{
    public partial class FrmMain : Form
    {
        private readonly Templates _templates;
        public static UcTabControl SlangTabControl;
        public FrmMain()
        {
            InitializeComponent();
            this.FileExplorer.BuildTreeView();
            var s = new Preferences.Shortcut();
            s.Bind();
            Text = $"{Sessions.SlangProject.Name} - Slang IDE";
            MainMenuStrip.Renderer = new DarkThemeRenderer();

            PaintAllComponents();
        }

        private void PaintAllComponents()
        {
            /* Menu Items */
            #region Headers
            var _file = new ToolStripMenuItem();
            _file.Text = "&File";
            _file.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _file.Name = "{2AD31557-A841-47E2-835B-6BCAE286E486}";

            var _newProject = new ToolStripMenuItem();
            _file.DropDownItems.Add(_newProject);
            _newProject.Text = "New Project";
            _newProject.ForeColor = Color.WhiteSmoke;
            _newProject.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _newProject.Name = "{5B6D512B-CB86-4A8F-91AF-2DCE0569BE3F}";

            var _recentProjects = new ToolStripMenuItem();
            _file.DropDownItems.Add(_recentProjects);
            _recentProjects.ForeColor = Color.WhiteSmoke;
            _recentProjects.Text = "Recent Projects";
            _recentProjects.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _newProject.Name = "{A843B137-28E3-4842-BEB0-17A7C7D41437}";

            _file.DropDownItems.Add(new ToolStripSeparator()
            {
                BackColor = Color.FromArgb(31, 31,31)
            });

            var _exitApplication = new ToolStripMenuItem();
            _file.DropDownItems.Add(_exitApplication);
            _exitApplication.ForeColor = Color.WhiteSmoke;
            _exitApplication.Text = "Exit";
            _exitApplication.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _exitApplication.Name = "{0FC4B816-6630-4A57-8C0D-A5B7A1C6E94D}";

            var _edit = new ToolStripMenuItem();
            _edit.Text = "&Edit";
            _edit.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _edit.Name = "{3CB0541E-C0B1-499B-BB10-05C17E8E25A7}";

            var _save = new ToolStripMenuItem();
            _edit.DropDownItems.Add(_save);
            _save.ForeColor = Color.WhiteSmoke;
            _save.Text = "Save";
            _save.ShowShortcutKeys = true;
            _save.ShortcutKeys = Keys.Control | Keys.S;
            _save.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _save.Name = "{E48C02F8-BCCD-4952-B865-FD20F0BBBE1C}";
            _save.Click += BtnSave_Click;

            var _saveAll = new ToolStripMenuItem();
            _edit.DropDownItems.Add(_saveAll);
            _saveAll.ForeColor = Color.WhiteSmoke;
            _saveAll.Text = "Save All";
            _saveAll.ShowShortcutKeys = true;
            _saveAll.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            _saveAll.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _saveAll.Name = "{AD0947D5-18C5-4A74-A6CC-3335F49652F7}";
            _saveAll.Click += BtnSaveAll_Click;

            _edit.DropDownItems.Add(new ToolStripSeparator()
            {
                BackColor = Color.FromArgb(31, 31, 31)
            });

            var _cut = new ToolStripMenuItem();
            _edit.DropDownItems.Add(_cut);
            _cut.ForeColor = Color.WhiteSmoke;
            _cut.Text = "Paste";
            _cut.ShowShortcutKeys = true;
            _cut.ShortcutKeys = Keys.Control | Keys.X;
            _cut.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _cut.Name = "{9DAEDF5A-D457-4BE5-99DD-8C609F4D8BB6}";

            var _copy = new ToolStripMenuItem();
            _edit.DropDownItems.Add(_copy);
            _copy.ForeColor = Color.WhiteSmoke;
            _copy.Text = "Copy";
            _copy.ShowShortcutKeys = true;
            _copy.ShortcutKeys = Keys.Control | Keys.C;
            _copy.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _copy.Name = "{46C1714B-7CC5-4A55-8845-3EED3AAD419F}";
            //_copy.Click += BtnSaveAll_Click;

            var _paste = new ToolStripMenuItem();
            _edit.DropDownItems.Add(_paste);
            _paste.ForeColor = Color.WhiteSmoke;
            _paste.Text = "Paste";
            _paste.ShowShortcutKeys = true;
            _paste.ShortcutKeys = Keys.Control | Keys.V;
            _paste.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _paste.Name = "{0FF35F47-7357-4D3D-85F7-DD4661F1A464}";

            var _selectAll = new ToolStripMenuItem();
            _edit.DropDownItems.Add(_selectAll);
            _selectAll.ForeColor = Color.WhiteSmoke;
            _selectAll.Text = "Select All";
            _selectAll.ShowShortcutKeys = true;
            _selectAll.ShortcutKeys = Keys.Control | Keys.A;
            _selectAll.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _selectAll.Name = "{8412BF81-0790-4527-9E59-C5C005D6F7CD}";


            var _build = new ToolStripMenuItem();
            _build.Text = "&Build";
            _build.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _build.Name = "{1E4E671A-3C4D-44AD-BFE5-E8C525A7A363}";

            var _options = new ToolStripMenuItem();
            _options.Text = "&Options";
            _options.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _options.Name = "{BAE30586-48BC-44A8-AF3E-BA2399D74B18}";

            var _preferences = new ToolStripMenuItem();
            _options.DropDownItems.Add(_preferences);
            _preferences.Text = "Preferences";
            _preferences.ForeColor = Color.WhiteSmoke;
            _preferences.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _preferences.Name = "{EEB68D2D-8DE1-4508-ABD4-844FEDEC1E95}";
            _preferences.Click += OpenPreferences;

            var _title = new ToolStripLabel();
            _title.Text = $"{Sessions.SlangProject.Name} - Slang IDE";
            _title.BackColor = Color.FromArgb(61, 61, 61);
            _title.ForeColor = Color.WhiteSmoke;
            //Add these controls to main menu
            MainMenuStrip.Items.Add(new ToolStripSeparator());
            MainMenuStrip.Items.AddRange(new ToolStripMenuItem[] { _file, _edit, _build, _options });
            MainMenuStrip.ForeColor = Color.WhiteSmoke;
            #endregion

            SlangTabControl = new UcTabControl();
            PanelContainer.Panel2.Controls.Add(SlangTabControl);
            SlangTabControl.Dock = DockStyle.Fill;

        }

        private void OpenPreferences(object sender, EventArgs e)
        {
            using var preferenceForm = new FrmPreferences();
            preferenceForm.ShowDialog();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Tsi_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Check if there is a tab opened
            
            if(SlangTabControl.TabPages.Count <= 0)
            {
                return;
            }

            var selectedTab = SlangTabControl.SelectedTab;
            var filesText = selectedTab.Text;

            var editor = selectedTab.Controls[0] as UcTextEditor;
            

            // Find the file (TODO: may this is not correct because under different paths may has the same file
            var actualFile = Sessions.SlangProject.Files.FirstOrDefault(x => x.Name == filesText && x.FileType == Slang.IDE.Shared.Enumerations.TreeFileType.File);

            if(actualFile == null)
            {
                return;
            }

            using var streamWriter = new StreamWriter(actualFile.FilePath);
            streamWriter.WriteLine(editor.EditorText);
        }

        private void BtnSaveAll_Click(object sender, EventArgs e)
        {
            if (SlangTabControl.TabPages.Count <= 0)
            {
                return;
            }

            foreach(TabPage tabPage  in SlangTabControl.TabPages)
            {
                var filesText = tabPage.Text;

                var editor = tabPage.Controls[0] as UcTextEditor;


                // Find the file (TODO: may this is not correct because under different paths may has the same file
                var actualFile = Sessions.SlangProject.Files.FirstOrDefault(x => x.Name == filesText && x.FileType == Slang.IDE.Shared.Enumerations.TreeFileType.File);

                if (actualFile == null)
                {
                    return;
                }

                using var streamWriter = new StreamWriter(actualFile.FilePath);
                streamWriter.WriteLine(editor.EditorText);
            }
        }


        //protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        //{
        //    if (SystemPreferences.Shortcuts.ContainsKey(keyData))
        //    {
        //        SystemPreferences.Shortcuts[keyData].Invoke();
        //        return true;
        //    }

        //    return base.ProcessCmdKey(ref msg, keyData);
        //}
    }
}
