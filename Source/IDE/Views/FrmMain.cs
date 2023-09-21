using IDE.Controls;
using IDE.Events;
using IDE.Helper;
using IDE.Helper.Custom;
using IDE.Preferences;
using IDE.Properties;
using IDE.Views.AdditionViews;
using IDE.Views.ToolWindows;
using Slang.IDE.Cache.Queries;
using Slang.IDE.Shared.Enumerations;
using System.Diagnostics;
using WeifenLuo.WinFormsUI.Docking;

namespace IDE.Views
{
    public partial class FrmMain : Form
    {
        private UcFileExplorer FileExplorer;
        private ToolWindowOutput OutputWindow;
        private ToolWindowBreakpoints BreakpointWindow;
        private ToolWindowBookmarks BookmarkWindow;

        private bool isNewProject = false;


        #region Custom Events
        public event EventHandler BookmarkChanged;
        #endregion

#pragma warning disable CS8618
        public FrmMain()
        {
            InitializeComponent();
            InitialiseToolWindows();
            CheckForFeatures();
            Text = $"{Sessions.SlangProject.Name} - Slang IDE | ALPHA 0.0.10.2";
            FileExplorer!.BuildTreeView();
            InitialiseTreeViewEvents();
            MainMenuStrip.Renderer = new DarkThemeRenderer();
            PaintAllComponents();

            var s = new Preferences.Shortcut();
            MainDockPanel.DockLeftPortion = 0.15;
            MainDockPanel.DockRightPortion = 0.15;
            s.Bind();
        }

        private void CheckForFeatures()
        {
            if (!Features.DebugMode)
            {
                this.EditorsTools.Items.Remove(this.BtnDebug);
            }
        }
#pragma warning restore CS8618

        #region Helper Functions 
        private void InitialiseToolWindows()
        {
            FileExplorer ??= new UcFileExplorer()
            {
                Name = "FileExplorer",
            };

            FileExplorer.Width = 200;
            FileExplorer.Show(MainDockPanel, WeifenLuo.WinFormsUI.Docking.DockState.DockLeft);
        }

        private void InitialiseTreeViewEvents()
        {
            FileExplorer.FileExplorerTree.NodeMouseDoubleClick += FileExplorerTree_NodeMouseDoubleClick;
        }

        private void PaintAllComponents()
        {
            /* Menu Items */
            #region Headers
            var _file = new ToolStripMenuItem
            {
                Text = "&File",
                DisplayStyle = ToolStripItemDisplayStyle.Text,
                Name = "{2AD31557-A841-47E2-835B-6BCAE286E486}"
            };

            var _newProject = new ToolStripMenuItem();
            _file.DropDownItems.Add(_newProject);
            _newProject.Text = "New Project";
            _newProject.ForeColor = Color.WhiteSmoke;
            _newProject.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _newProject.Name = "{5B6D512B-CB86-4A8F-91AF-2DCE0569BE3F}";
            _newProject.Click += _newProject_Click;

            var _recentProjects = new ToolStripMenuItem();
            _file.DropDownItems.Add(_recentProjects);
            _recentProjects.ForeColor = Color.WhiteSmoke;
            _recentProjects.Text = "Recent Projects";
            _recentProjects.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _recentProjects.Name = "{A843B137-28E3-4842-BEB0-17A7C7D41437}";

            _file.DropDownItems.Add(new DarkThemeToolStripSeparator());

            var _exitApplication = new ToolStripMenuItem();
            _file.DropDownItems.Add(_exitApplication);
            _exitApplication.ForeColor = Color.WhiteSmoke;
            _exitApplication.Text = "Exit";
            _exitApplication.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _exitApplication.Name = "{0FC4B816-6630-4A57-8C0D-A5B7A1C6E94D}";
            _exitApplication.Click += Tsi_Exit_Click;

            var _edit = new ToolStripMenuItem
            {
                Text = "&Edit",
                DisplayStyle = ToolStripItemDisplayStyle.Text,
                Name = "{3CB0541E-C0B1-499B-BB10-05C17E8E25A7}"
            };

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

            var _findAndReplace = new ToolStripMenuItem();
            _edit.DropDownItems.Add(_findAndReplace);
            _findAndReplace.ForeColor = Color.WhiteSmoke;
            _findAndReplace.Text = "&Find && &Replace";
            _findAndReplace.Name = "{B4F64CC4-87C2-4617-B2A3-B0B70EAD66A8}";

            var _quickFind = new ToolStripMenuItem();
            _findAndReplace.DropDownItems.Add(_quickFind);
            _quickFind.ForeColor = Color.WhiteSmoke;
            _quickFind.Text = "&Quick Find";
            _quickFind.ShowShortcutKeys = true;
            _quickFind.ShortcutKeys = Keys.Control | Keys.F;
            _quickFind.Name = "{BD6EBEDC-AB4B-4C02-A98E-8D71A4B2A6AF}";
            _quickFind.Click += QuickFind;

            var _advanceFind = new ToolStripMenuItem();
            _findAndReplace.DropDownItems.Add(_advanceFind);
            _advanceFind.ForeColor = Color.WhiteSmoke;
            _advanceFind.Text = "&Advanced Find";
            _advanceFind.ShowShortcutKeys = true;
            _advanceFind.ShortcutKeys = Keys.Control | Keys.Shift | Keys.F;
            _advanceFind.Name = "{F1865F55-1B9F-45B4-8BC7-80E113DD61BA}";
            _advanceFind.Click += AdvanceFind;

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

            _edit.DropDownItems.Add(new DarkThemeToolStripSeparator());

            var _bookmarks = new ToolStripMenuItem();
            _edit.DropDownItems.Add(_bookmarks);
            _bookmarks.ForeColor = Color.WhiteSmoke;
            _bookmarks.Text = "Bookmarks";
            _bookmarks.Name = "{3B40BF38-2782-4A0C-ADD2-0780B289A189}";

            var _toggleBookmark = new ToolStripMenuItem();
            _bookmarks.DropDownItems.Add(_toggleBookmark);
            _toggleBookmark.ForeColor = Color.WhiteSmoke;
            _toggleBookmark.Text = "Toggle Bookmark";
            _toggleBookmark.Name = "{5FF0043D-C3D1-48D3-94E0-C2777E4ABBA5}";
            _toggleBookmark.ShowShortcutKeys = true;
            _toggleBookmark.ShortcutKeys = Keys.Control | Keys.K;
            _toggleBookmark.Click += ToggleBookmark;

            var _removeAllBookmarks = new ToolStripMenuItem();
            _bookmarks.DropDownItems.Add(_removeAllBookmarks);
            _removeAllBookmarks.ForeColor = Color.WhiteSmoke;
            _removeAllBookmarks.Text = "Remove all Bookmarks";
            _removeAllBookmarks.Name = "{2bd41a6a-b059-427f-a1be-1cec4bd0b2cb}";
            _removeAllBookmarks.ShowShortcutKeys = true;
            _removeAllBookmarks.ShortcutKeys = Keys.Control | Keys.D;
            _removeAllBookmarks.Click += DeleteAllBookmarks;


            var _view = new ToolStripMenuItem
            {
                Text = "&View",
                DisplayStyle = ToolStripItemDisplayStyle.Text,
                Name = "{2B4BEB13-BA3D-44A2-BD29-95B6329BA6F1}"
            };

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

            if (Features.BreakpointEnable)
            {
                var _breakpointView = new ToolStripMenuItem();
                _view.DropDownItems.Add(_breakpointView);
                _breakpointView.ForeColor = Color.WhiteSmoke;
                _breakpointView.Text = "Breakpoints Window";
                _breakpointView.DisplayStyle = ToolStripItemDisplayStyle.Text;
                _breakpointView.Name = "{098DB9F1-30A8-47D0-9C64-28769CD0A602}";
                _breakpointView.Click += ShowBreakpoints; 
            }

            if (Features.BookmarkEnable)
            {
                var _bookmarkWindow = new ToolStripMenuItem();
                _view.DropDownItems.Add(_bookmarkWindow);
                _bookmarkWindow.ForeColor = Color.WhiteSmoke;
                _bookmarkWindow.Text = "Bookmarks Window";
                _bookmarkWindow.DisplayStyle = ToolStripItemDisplayStyle.Text;
                _bookmarkWindow.Name = "{8BD5BACE-4F39-4853-A6BA-B81C368F7C20}";
                _bookmarkWindow.Click += ShowBookmark; 
            }

            var _debug = new ToolStripMenuItem
            {
                Text = "&Debug",
                DisplayStyle = ToolStripItemDisplayStyle.Text,
                Name = "{1E4E671A-3C4D-44AD-BFE5-E8C525A7A363}"
            };


            var _runWithoutDebug = new ToolStripMenuItem();
            _debug.DropDownItems.Add(_runWithoutDebug);
            _runWithoutDebug.ForeColor = Color.WhiteSmoke;
            _runWithoutDebug.Text = "Run without Debugging";
            _runWithoutDebug.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _runWithoutDebug.Name = "{235AC2D7-813A-4084-AC43-8E43FCBC2BFB}";
            _runWithoutDebug.ShortcutKeys = Keys.F5;
            _runWithoutDebug.Click += BtnRun_Click;

            var _tools = new ToolStripMenuItem
            {
                Text = "&Tools",
                DisplayStyle = ToolStripItemDisplayStyle.Text,
                Name = "{203ad593-4af3-4440-8739-503098765556}"
            };

            var _guidgenerator = new ToolStripMenuItem();
            _tools.DropDownItems.Add(_guidgenerator);
            _guidgenerator.ForeColor = Color.WhiteSmoke;
            _guidgenerator.Text = "GUID Generator";
            _guidgenerator.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _guidgenerator.Name = "{aa7215ff-8d7e-41e5-910d-66c6f8ef19f6}";
            _guidgenerator.Click += OpenGuidGenerator;

            var _options = new ToolStripMenuItem
            {
                Text = "&Options",
                DisplayStyle = ToolStripItemDisplayStyle.Text,
                Name = "{BAE30586-48BC-44A8-AF3E-BA2399D74B18}"
            };

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

            //Add these controls to main menu
            MainMenuStrip.Items.Add(new ToolStripSeparator());
            MainMenuStrip.Items.AddRange(new ToolStripMenuItem[] { _file, _edit,  _view, _debug, _tools, _options });
            MainMenuStrip.ForeColor = Color.WhiteSmoke;
            #endregion
        }

        private void _newProject_Click(object sender, EventArgs e)
        {
            isNewProject = true;
            this.Hide();
            var frm = new FrmProjectsList();
            frm.ShowDialog();
        }
        #endregion

        #region TreeView's Events
        private void FileExplorerTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var selectedNode = e.Node as TreeNodeExtented;

            if (selectedNode!.FileType is TreeFileType.Folder or TreeFileType.Solution)
            {
                return;
            }

            OpenTextEditor(e.Node.Name);
        }


        #endregion

        #region Form's Events 
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isNewProject)
            {
                Application.Exit();
            }

            
        }
        #endregion

        #region Text Editor Event 
        private void Uc_textEditor_CaretPositionChanged(object sender, CaretPositionEventArgs e)
        {
            LblLine.Text = e.Line.ToString();
            LblColumn.Text = e.Column.ToString();
            LblPosition.Text = e.Position.ToString();
        }

        private void Uc_textEditor_BreakpointDeleted(object sender, EventArgs e)
        {
            if (BreakpointWindow is null || BreakpointWindow.IsDisposed)
                return;

            BreakpointWindow.ClearBreakpointList();

            foreach (var breakpoint in Sessions.Breakpoints)
            {
                BreakpointWindow.AddBreakpointToList(breakpoint.Name, breakpoint.FilePath, breakpoint.Line.ToString());
            }
        }

        private void Uc_textEditor_BreakpointAdded(object sender, EventArgs e)
        {
            if (BreakpointWindow is null || BreakpointWindow.IsDisposed)
                return;

            BreakpointWindow.ClearBreakpointList();

            foreach (var breakpoint in Sessions.Breakpoints)
            {
                BreakpointWindow.AddBreakpointToList(breakpoint.Name, breakpoint.FilePath, breakpoint.Line.ToString());
            }
        }

        private void Uc_textEditor_BookmarkAdded(object sender, BookmarkEventArgs e)
        {

            BookmarkQueriesCollection.Insert(e.FileId, e.FileLocation, e.Line);
            BookmarkChanged?.Invoke(this, new EventArgs());

        }

        private void Uc_textEditor_BookmarkDeleted(object sender, BookmarkEventArgs e)
        {
            BookmarkQueriesCollection.Delete(e.FileId, e.FileLocation, e.Line);
            BookmarkChanged?.Invoke(this, new EventArgs());
        }

        #endregion

        #region Menu Strip Events & Tool bar  
        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Check if there is a tab opened

            if (MainDockPanel.Documents.FirstOrDefault(x => x.DockHandler.IsActivated) is not SlangTextEditor selectedForm)
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

            try
            {
                using var streamWriter = new StreamWriter($"{Sessions.ProjectPath}/{actualFile.FilePath}");
                streamWriter.WriteLine(selectedForm.EditorText);
            }
            catch (Exception ex)
            {
                LblStatusMessage.Text = $"An error has occured: {ex.Message}";
                return;
            }

            LblStatusMessage.Text = $"{filesText} has been saved";
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

                    try
                    {
                        using var streamWriter = new StreamWriter($"{Sessions.ProjectPath}/{actualFile.FilePath}");
                        streamWriter.WriteLine(editor.EditorText);
                    }
                    catch (Exception ex)
                    {
                        LblStatusMessage.Text = $"An error has occured when trying to save {filesText}";
                        return;
                    }
                }
            }

            LblStatusMessage.Text = $"Item(s) Saved";
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
            BtnSaveAll_Click(sender, e);

            LblStatusMessage.Text = $"Build Started...";
            ShowOutput(sender, e);
            OutputWindow.WriteLine("Compiling has been started...");
            var startInfo = new ProcessStartInfo
            {
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                RedirectStandardInput = true,
                Arguments = $"{Sessions.ProjectPath}/{Sessions.SlangProject.Files.First(x => x.Name == "main.slang").FilePath}",
                CreateNoWindow = true,
                FileName = Settings.Default.SlangMiddlewarePath
            };

            var process = new Process
            {
                StartInfo = startInfo
            };
            process.OutputDataReceived += (ss, ee) =>
            {
                LblStatusMessage.Text = $"Build Completed...";
                OutputWindow.WriteLine(ee.Data, Color.Green);
            };

            process.Start();
            process.BeginOutputReadLine();
        }

        private void Tsi_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

            foreach (IDockContent dockContent in MainDockPanel.Documents)
            {
                if (dockContent is SlangTextEditor editor)
                {
                    editor.ReloadFonts();
                }
            }
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

        private void ShowBreakpoints(object sender, EventArgs e)
        {
            if (BreakpointWindow is null || BreakpointWindow.IsDisposed)
            {
                BreakpointWindow = new ToolWindowBreakpoints();
            }

            BreakpointWindow.Show(MainDockPanel, DockState.DockBottom);
        }

        private void OpenGuidGenerator(object sender, EventArgs e)
        {
            var startInfo = new ProcessStartInfo
            {
                FileName = "guidgenerator.exe"
            };
            Process.Start(startInfo);
        }

        private void ShowFileExplorer(object sender, EventArgs e)
        {
            if (FileExplorer.IsDisposed || FileExplorer is null)
            {
                FileExplorer = new UcFileExplorer();
            }

            FileExplorer.Show(MainDockPanel, WeifenLuo.WinFormsUI.Docking.DockState.DockLeft);
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            FillRecentProjects();
        }

        private void OpenRencentProject(object sender, EventArgs e)
        {
            var recentProject = (RecentProject)((ToolStripMenuItem)sender).Tag;

            var startInfo = new ProcessStartInfo
            {
                FileName = "slangdev.exe",
                Arguments = recentProject.Path
            };

            var process = new Process
            {
                StartInfo = startInfo
            };
            process.Start();
        }

        private void DeleteAllBookmarks(object sender, EventArgs e)
        {
            BookmarkQueriesCollection.RemoveAllBookmarks();
            BookmarkChanged?.Invoke(this, new EventArgs());

            foreach (SlangTextEditor form in MainDockPanel.Documents.Cast<SlangTextEditor>())
            {
                form.DeleteAllBookmarks();
            }
        }

        private void ShowBookmark(object sender, EventArgs e)
        {
            if (BookmarkWindow is null || BookmarkWindow.IsDisposed)
            {
                BookmarkWindow = new ToolWindowBookmarks(this);
                BookmarkWindow.ItemDoubleClick += BookmarkWindow_ItemDoubleClick;
            }

            BookmarkWindow.Show(MainDockPanel, DockState.DockBottom);


        }

        private void ToggleBookmark(object sender, EventArgs e)
        {
            if (MainDockPanel.Documents.FirstOrDefault(x => x.DockHandler.IsActivated) is not SlangTextEditor selectedForm)
            {
                return;
            }

            selectedForm.ToggleBookmark();
        }

        private void AdvanceFind(object sender, EventArgs e)
        {
            if (MainDockPanel.Documents.FirstOrDefault(x => x.DockHandler.IsActivated) is not SlangTextEditor selectedForm)
                return;

            selectedForm.ShowAdvancedFind();
        }

        private void QuickFind(object sender, EventArgs e)
        {
            if (MainDockPanel.Documents.FirstOrDefault(x => x.DockHandler.IsActivated) is not SlangTextEditor selectedForm)
                return;

            selectedForm.ShowQuickFind();
        }
        #endregion

        #region Tool Window Events
        private void BookmarkWindow_ItemDoubleClick(object sender, BookmarkDoubleClickEventArgs e)
        {
            OpenTextEditor(e.Bookmark.Id);

            if (MainDockPanel.Documents.First(x => x.DockHandler.IsActivated) is not SlangTextEditor selectedForm)
            {
                return;
            }

            selectedForm.textEditor.GotoPosition(selectedForm.textEditor.Lines[e.Bookmark.Line - 1].Position);
        }
        #endregion

        private void BtnDebug_Click(object sender, EventArgs e)
        {
            var d = 0;
            var v = 5;

            Console.WriteLine(v / d);
        }


        #region Methods
        private void OpenTextEditor(string fileId)
        {
            var file = Sessions.SlangProject.Files.First(x => x.Id == Guid.Parse(fileId));

            var dockPanel = MainDockPanel.Documents.FirstOrDefault(x => x.DockHandler.TabText == file.Name);

            if (dockPanel != null)
            {
                dockPanel.DockHandler.Activate();
                return;
            }

            // Open the file
            var text = File.ReadAllText(Path.Combine(Sessions.ProjectPath, file.FilePath));

            var uc_textEditor = new SlangTextEditor
            {
                Text = file.Name,
                EditorText = text,
                FilePath = file.FilePath
            };
            uc_textEditor.CaretPositionChanged += Uc_textEditor_CaretPositionChanged;
            uc_textEditor.BreakpointAdded += Uc_textEditor_BreakpointAdded;
            uc_textEditor.BreakpointDeleted += Uc_textEditor_BreakpointDeleted;
            uc_textEditor.BookmarkAdded += Uc_textEditor_BookmarkAdded;
            uc_textEditor.BookmarkDeleted += Uc_textEditor_BookmarkDeleted;

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

        private Task FillRecentProjects()
        {
            var recentProjects = Functions.LoadRecent();

            if (!recentProjects.Any())
                return Task.CompletedTask;

            foreach (var recentProject in recentProjects)
            {
                var toolStripMenu = new ToolStripMenuItem
                {
                    Name = Guid.NewGuid().ToString("B"),
                    Tag = recentProject,
                    ForeColor = Color.WhiteSmoke,
                    Text = $"{recentProject.Name} ({recentProject.Path})"
                };
                toolStripMenu.Click += OpenRencentProject;
                ToolStripMenuItem recentMenu = (ToolStripMenuItem)MainMenuStrip.Items.Find("{A843B137-28E3-4842-BEB0-17A7C7D41437}", true)[0]!;
                recentMenu.DropDownItems.Add(toolStripMenu);
            }

            return Task.CompletedTask;
        }
        #endregion


    }
}
