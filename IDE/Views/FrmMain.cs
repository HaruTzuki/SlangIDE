﻿using IDE.Controls;
using IDE.Helper;
using IDE.Helper.Custom;
using IDE.Preferences;
using IDE.Views.AdditionViews;
using Slang.IDE.Shared.Enumerations;

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

            InitialiseTreeViewEvents();

            PaintAllComponents();
        }

        private void InitialiseTreeViewEvents()
        {
            this.FileExplorer.FileExplorerTree.NodeMouseDoubleClick += FileExplorerTree_NodeMouseDoubleClick;
        }

        private void FileExplorerTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var selectedNode = e.Node as TreeNodeExtented;

            if (selectedNode.FileType == TreeFileType.Folder || selectedNode.FileType == TreeFileType.Solution)
            {
                return;
            }

            var file = Sessions.SlangProject.Files.FirstOrDefault(x => x.Id == Guid.Parse(e.Node.Name));

            if (FrmMain.SlangTabControl.TabPages.ContainsKey(file.Id.ToString()))
            {
                FrmMain.SlangTabControl.SelectedTab = FrmMain.SlangTabControl.TabPages[file.Id.ToString()];
                return;
            }

            // Open the file
            using var streamReader = new StreamReader(file.FilePath);
            var content = streamReader.ReadToEnd();
            streamReader.Close();

            var uc_textEditor = new SlangTextEditor();
            uc_textEditor.EditorText = content;
            uc_textEditor.Dock = DockStyle.Fill;
            uc_textEditor.CaretPositionChanged += Uc_textEditor_CaretPositionChanged;

            var tabPage = new TabPage();
            tabPage.Name = file.Id.ToString();
            tabPage.Text = file.Name;
            tabPage.Controls.Add(uc_textEditor);

            SlangTabControl.TabPages.Add(tabPage);
            SlangTabControl.SelectedTab = SlangTabControl.TabPages[file.Id.ToString()];
        }
        private void Uc_textEditor_CaretPositionChanged(object sender, CaretPositionEventArgs e)
        {
            LblLine.Text = e.Line.ToString();
            LblPosition.Text = e.Column.ToString();
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

            _file.DropDownItems.Add(new DarkThemeToolStripSeparator());

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

            _edit.DropDownItems.Add(new DarkThemeToolStripSeparator());

            var _undo = new ToolStripMenuItem();
            _edit.DropDownItems.Add(_undo);
            _undo.ForeColor = Color.WhiteSmoke;
            _undo.Text = "Undo";
            _undo.ShowShortcutKeys = true;
            _undo.ShortcutKeys = Keys.Control | Keys.Z;
            _undo.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _undo.Name = "{7AD0441F-90AC-42C4-8D88-1CA74EB96902}";
            _undo.Click += BtnUndo_Click;

            var _redo = new ToolStripMenuItem();
            _edit.DropDownItems.Add(_redo);
            _redo.ForeColor = Color.WhiteSmoke;
            _redo.Text = "Redo";
            _redo.ShowShortcutKeys = true;
            _redo.ShortcutKeys = Keys.Control | Keys.Y;
            _redo.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _redo.Name = "{EA4BCD41-F825-402E-BBD4-A953180DA5F8}";
            _redo.Click += BtnRedo_Click;

            _edit.DropDownItems.Add(new DarkThemeToolStripSeparator());

            var _cut = new ToolStripMenuItem();
            _edit.DropDownItems.Add(_cut);
            _cut.ForeColor = Color.WhiteSmoke;
            _cut.Text = "Cut";
            _cut.ShowShortcutKeys = true;
            _cut.ShortcutKeys = Keys.Control | Keys.X;
            _cut.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _cut.Name = "{9DAEDF5A-D457-4BE5-99DD-8C609F4D8BB6}";
            _cut.Click += BtnCut_Click;

            var _copy = new ToolStripMenuItem();
            _edit.DropDownItems.Add(_copy);
            _copy.ForeColor = Color.WhiteSmoke;
            _copy.Text = "Copy";
            _copy.ShowShortcutKeys = true;
            _copy.ShortcutKeys = Keys.Control | Keys.C;
            _copy.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _copy.Name = "{46C1714B-7CC5-4A55-8845-3EED3AAD419F}";
            _copy.Click += BtnCopy_Click;

            var _paste = new ToolStripMenuItem();
            _edit.DropDownItems.Add(_paste);
            _paste.ForeColor = Color.WhiteSmoke;
            _paste.Text = "Paste";
            _paste.ShowShortcutKeys = true;
            _paste.ShortcutKeys = Keys.Control | Keys.V;
            _paste.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _paste.Name = "{0FF35F47-7357-4D3D-85F7-DD4661F1A464}";
            _paste.Click += BtnPaste_Click;

            var _selectAll = new ToolStripMenuItem();
            _edit.DropDownItems.Add(_selectAll);
            _selectAll.ForeColor = Color.WhiteSmoke;
            _selectAll.Text = "Select All";
            _selectAll.ShowShortcutKeys = true;
            _selectAll.ShortcutKeys = Keys.Control | Keys.A;
            _selectAll.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _selectAll.Name = "{8412BF81-0790-4527-9E59-C5C005D6F7CD}";
            _selectAll.Click += BtnSelectAll_Click;


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

            _options.DropDownItems.Add(new DarkThemeToolStripSeparator());

            var _about = new ToolStripMenuItem();
            _options.DropDownItems.Add(_about);
            _about.Text = "About";
            _about.ForeColor = Color.WhiteSmoke;
            _about.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _about.Name = "{3CA68831-6586-4E72-9DCE-7894E4A43D52}";
            _about.Click += OpenAbout;


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

        private void OpenAbout(object sender, EventArgs e)
        {
            using var aboutForm = new FrmAbout();
            aboutForm.ShowDialog();
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

            var editor = selectedTab.Controls[0] as SlangTextEditor;
            

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

                var editor = tabPage.Controls[0] as SlangTextEditor;


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

        private void BtnUndo_Click(object sender, EventArgs e)
        {
            if(SlangTabControl.TabPages.Count <= 0)
            {
                return;
            }

            var selectedTab = SlangTabControl.SelectedTab;

            if(selectedTab.Controls.Count <= 0)
            {
                return;
            }

            var textEditor = selectedTab.Controls[0] as SlangTextEditor;

            if(textEditor!.textEditor.CanUndo)
            {
                textEditor.textEditor.Undo();
            }
        }

        private void BtnRedo_Click(object sender, EventArgs e)
        {
            if (SlangTabControl.TabPages.Count <= 0)
            {
                return;
            }

            var selectedTab = SlangTabControl.SelectedTab;

            if (selectedTab.Controls.Count <= 0)
            {
                return;
            }

            var textEditor = selectedTab.Controls[0] as SlangTextEditor;

            if (textEditor!.textEditor.CanRedo)
            {
                textEditor.textEditor.Redo();
            }
        }

        private void BtnSelectAll_Click(object sender, EventArgs e)
        {
            if (SlangTabControl.TabPages.Count <= 0)
            {
                return;
            }

            var selectedTab = SlangTabControl.SelectedTab;

            if (selectedTab.Controls.Count <= 0)
            {
                return;
            }

            var textEditor = selectedTab.Controls[0] as SlangTextEditor;

            textEditor!.textEditor.SelectAll();
        }

        private void BtnPaste_Click(object sender, EventArgs e)
        {
            if (SlangTabControl.TabPages.Count <= 0)
            {
                return;
            }

            var selectedTab = SlangTabControl.SelectedTab;

            if (selectedTab.Controls.Count <= 0)
            {
                return;
            }

            var textEditor = selectedTab.Controls[0] as SlangTextEditor;

            textEditor!.textEditor.Paste();
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            if (SlangTabControl.TabPages.Count <= 0)
            {
                return;
            }

            var selectedTab = SlangTabControl.SelectedTab;

            if (selectedTab.Controls.Count <= 0)
            {
                return;
            }

            var textEditor = selectedTab.Controls[0] as SlangTextEditor;

            textEditor!.textEditor.Copy();
        }

        private void BtnCut_Click(object sender, EventArgs e)
        {
            if (SlangTabControl.TabPages.Count <= 0)
            {
                return;
            }

            var selectedTab = SlangTabControl.SelectedTab;

            if (selectedTab.Controls.Count <= 0)
            {
                return;
            }

            var textEditor = selectedTab.Controls[0] as SlangTextEditor;

            textEditor!.textEditor.Cut();
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
