using IDE.Controls;
using IDE.Helper;
using IDE.Helper.Custom;
using IDE.Preferences;
using IDE.Views.AdditionViews;
using IDE.Views.ToolWindows;
using Slang.IDE.Shared.Enumerations;
using System.Diagnostics;
using WeifenLuo.WinFormsUI.Docking;

namespace IDE.Views
{
    public partial class FrmMain : Form
    {
        private readonly Templates _templates;
        private UcFileExplorer FileExplorer;
        private ToolWindowOutput OutputWindow;
        public FrmMain()
        {
            InitializeComponent();
            InitialiseToolWindows();

            FileExplorer.BuildTreeView();
            var s = new Preferences.Shortcut();
            s.Bind();
            Text = $"{Sessions.SlangProject.Name} - Slang IDE";
            MainMenuStrip.Renderer = new DarkThemeRenderer();

            InitialiseTreeViewEvents();

            PaintAllComponents();
        }

        private void InitialiseToolWindows()
        {
            FileExplorer ??= new UcFileExplorer()
            {
                Name = "FileExplorer",
            };
            FileExplorer.Show(MainDockPanel, WeifenLuo.WinFormsUI.Docking.DockState.DockLeft);
        }

        private void InitialiseTreeViewEvents()
        {
            FileExplorer.FileExplorerTree.NodeMouseDoubleClick += FileExplorerTree_NodeMouseDoubleClick;
        }

        private void FileExplorerTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var selectedNode = e.Node as TreeNodeExtented;

            if (selectedNode.FileType == TreeFileType.Folder || selectedNode.FileType == TreeFileType.Solution)
            {
                return;
            }

            var file = Sessions.SlangProject.Files.FirstOrDefault(x => x.Id == Guid.Parse(e.Node.Name));

            var dockPanel = MainDockPanel.Documents.FirstOrDefault(x => x.DockHandler.TabText == file.Name);

            if (dockPanel != null)
            {
                dockPanel.DockHandler.Activate();
                return;
            }

            // Open the file
            var text = File.ReadAllText(file.FilePath);

            var uc_textEditor = new SlangTextEditor();
            uc_textEditor.Text = file.Name;
            uc_textEditor.EditorText = text;
            uc_textEditor.CaretPositionChanged += Uc_textEditor_CaretPositionChanged;

            if (MainDockPanel.DocumentStyle == WeifenLuo.WinFormsUI.Docking.DocumentStyle.SystemMdi)
            {
                uc_textEditor.MdiParent = this;
                uc_textEditor.Show();
            }
            else
            {
                uc_textEditor.Show(MainDockPanel);
            }
        }
        private void Uc_textEditor_CaretPositionChanged(object sender, CaretPositionEventArgs e)
        {
            LblLine.Text = e.Line.ToString();
            LblColumn.Text = e.Column.ToString();
            LblPosition.Text = e.Position.ToString();
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
            _exitApplication.Click += Tsi_Exit_Click;

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

            var _view = new ToolStripMenuItem();
            _view.Text = "&View";
            _view.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _view.Name = "{2B4BEB13-BA3D-44A2-BD29-95B6329BA6F1}";

            var _fileExplorerView = new ToolStripMenuItem();
            _view.DropDownItems.Add(_fileExplorerView);
            _fileExplorerView.ForeColor = Color.WhiteSmoke;
            _fileExplorerView.Text = "File Explorer";
            _fileExplorerView.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _fileExplorerView.Name = "{7591B4ED-2C67-4C45-A3DF-ABC581630A50}";
            _fileExplorerView.Click += ShowFileExplorer;

            var _outputView = new ToolStripMenuItem();
            _view.DropDownItems.Add(_outputView);
            _outputView.ForeColor = Color.WhiteSmoke;
            _outputView.Text = "Output";
            _outputView.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _outputView.Name = "{468A04C9-1A10-4F3F-9937-30A26375E2C4}";
            _outputView.Click += ShowOutput;

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
            MainMenuStrip.Items.AddRange(new ToolStripMenuItem[] { _file, _edit, _view, _build, _options });
            MainMenuStrip.ForeColor = Color.WhiteSmoke;
            #endregion


        }

        private async void ShowOutput(object sender, EventArgs e)
        {
            if (OutputWindow is null || OutputWindow.IsDisposed)
            {
                OutputWindow = new ToolWindowOutput();
            }

            OutputWindow.Show(MainDockPanel, DockState.DockBottom);

            OutputWindow.WriteLine("=== Slang IDE Output ===", Color.Red);
        }

        private void ShowFileExplorer(object sender, EventArgs e)
        {
            if (FileExplorer.IsDisposed || FileExplorer is null)
            {
                FileExplorer = new UcFileExplorer();
            }

            FileExplorer.Show(MainDockPanel, WeifenLuo.WinFormsUI.Docking.DockState.DockLeft);
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
            var selectedForm = MainDockPanel.Documents.FirstOrDefault(x => x.DockHandler.IsActivated) as SlangTextEditor;
            ;
            if (selectedForm == null)
            {
                return;
            }

            var filesText = selectedForm.Text;


            // Find the file (TODO: may this is not correct because under different paths may has the same file
            var actualFile = Sessions.SlangProject.Files.FirstOrDefault(x => x.Name == filesText && x.FileType == Slang.IDE.Shared.Enumerations.TreeFileType.File);

            if (actualFile == null)
            {
                return;
            }

            using var streamWriter = new StreamWriter(actualFile.FilePath);
            streamWriter.WriteLine(selectedForm.EditorText);
        }

        private void BtnSaveAll_Click(object sender, EventArgs e)
        {
            foreach (IDockContent dockContent in MainDockPanel.Documents)
            {
                if (dockContent is SlangTextEditor editor)
                {
                    var filesText = editor.Text;
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
        }

        private void BtnUndo_Click(object sender, EventArgs e)
        {
            // Check if there is a tab opened
            var selectedForm = MainDockPanel.Documents.FirstOrDefault(x => x.DockHandler.IsActivated);

            if (selectedForm is SlangTextEditor textEditor)
            {
                if (!textEditor.textEditor.CanUndo)
                {
                    return;
                }

                textEditor.textEditor.Undo();
            }
        }

        private void BtnRedo_Click(object sender, EventArgs e)
        {
            // Check if there is a tab opened
            var selectedForm = MainDockPanel.Documents.FirstOrDefault(x => x.DockHandler.IsActivated);

            if (selectedForm is SlangTextEditor textEditor)
            {
                if (!textEditor.textEditor.CanRedo)
                {
                    return;
                }

                textEditor.textEditor.Redo();
            }
        }

        private void BtnSelectAll_Click(object sender, EventArgs e)
        {
            var selectedForm = MainDockPanel.Documents.FirstOrDefault(x => x.DockHandler.IsActivated);

            if (selectedForm is SlangTextEditor textEditor)
            {
                textEditor.textEditor.SelectAll();
            }
        }

        private void BtnPaste_Click(object sender, EventArgs e)
        {
            var selectedForm = MainDockPanel.Documents.FirstOrDefault(x => x.DockHandler.IsActivated);

            if (selectedForm is SlangTextEditor textEditor)
            {
                textEditor.textEditor.Paste();
            }
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            var selectedForm = MainDockPanel.Documents.FirstOrDefault(x => x.DockHandler.IsActivated);

            if (selectedForm is SlangTextEditor textEditor)
            {
                textEditor.textEditor.Copy();
            }
        }

        private void BtnCut_Click(object sender, EventArgs e)
        {
            var selectedForm = MainDockPanel.Documents.FirstOrDefault(x => x.DockHandler.IsActivated);

            if (selectedForm is SlangTextEditor textEditor)
            {
                textEditor.textEditor.Cut();
            }
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            ShowOutput(sender, e);
            OutputWindow.WriteLine("Compiling has been started...");
            var startInfo = new ProcessStartInfo();
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.RedirectStandardInput = true;
            startInfo.Arguments = $"{Sessions.SlangProject.Files.First(x => x.Name == "main.slang").FilePath} -s";
            startInfo.CreateNoWindow = true;
            startInfo.FileName = "C:\\Projects\\SlangIDE\\SlangMiddleware\\bin\\Debug\\net7.0\\smc.exe";

            var process = new Process();
            process.StartInfo = startInfo;
            process.OutputDataReceived += (ss, ee) =>
            {
                OutputWindow.WriteLine(ee.Data, Color.Green);
            };

            process.Start();
            process.BeginOutputReadLine();
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
