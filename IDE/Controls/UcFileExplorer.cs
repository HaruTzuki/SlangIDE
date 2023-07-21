using IDE.Helper;
using IDE.Views;
using IDE.Views.AdditionViews;
using Slang.IDE.Shared.Enumerations;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms.VisualStyles;

namespace IDE.Controls
{
    public partial class UcFileExplorer : UserControl
    {
        public UcFileExplorer()
        {
            InitializeComponent();
        }

        public void BuildTreeView()
        {
            this.FileExplorerTree.Nodes.Clear();

            var root = new TreeNodeExtented();
            root.Name = Sessions.SlangProject.Id.ToString();
            root.Text = Sessions.SlangProject.Name;
            root.FileType = Slang.IDE.Shared.Enumerations.TreeFileType.Solution;

            this.FileExplorerTree.Nodes.Add(root);

            foreach (var withParent in Sessions.SlangProject.Files)
            {
                var parentNode = this.FileExplorerTree.Nodes.Find(withParent.ParentId.ToString(), true).First();

                if (withParent.FileType == Slang.IDE.Shared.Enumerations.TreeFileType.Folder)
                {
                    var _folderType = new TreeNodeExtented();
                    _folderType.Name = withParent.Id.ToString();
                    _folderType.Text = withParent.Name;
                    _folderType.ImageIndex = 0;
                    _folderType.SelectedImageIndex = 0;
                    _folderType.FileType = Slang.IDE.Shared.Enumerations.TreeFileType.Folder;
                    _folderType.FilePath = withParent.FilePath;
                    parentNode.Nodes.Add(_folderType);
                }
                else
                {
                    var _fileType = new TreeNodeExtented();
                    _fileType.Name = withParent.Id.ToString();
                    _fileType.Text = withParent.Name;
                    _fileType.ImageIndex = 1;
                    _fileType.SelectedImageIndex = 1;
                    _fileType.FileType = Slang.IDE.Shared.Enumerations.TreeFileType.File;
                    _fileType.FilePath = withParent.FilePath;
                    parentNode.Nodes.Add(_fileType);
                }
            }

            this.FileExplorerTree.ExpandAll();

        }


        private void FileExplorerTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var file = Sessions.SlangProject.Files.FirstOrDefault(x => x.Id == Guid.Parse(e.Node.Name));

            FrmMain.SlangTabControl.TabPages.fir
            
            // Open the file
            using var streamReader = new StreamReader(file.FilePath);
            var content = streamReader.ReadToEnd();
            streamReader.Close();

            var uc_textEditor = new UcTextEditor();
            uc_textEditor.EditorText = content;
            uc_textEditor.Dock = DockStyle.Fill;

            var tabPage = new TabPage();
            tabPage.Name = file.Id.ToString();
            tabPage.Text = file.Name;
            tabPage.Controls.Add(uc_textEditor);

            FrmMain.SlangTabControl.TabPages.Add(tabPage);
        }


        #region Context Menus
        private void BtnNewFolder_Click(object sender, EventArgs e)
        {
            var selectedNode = this.FileExplorerTree.SelectedNode as TreeNodeExtented;

            if (selectedNode.FileType == Slang.IDE.Shared.Enumerations.TreeFileType.File)
            {
                selectedNode = selectedNode.Parent as TreeNodeExtented;
            }

            using var newFileForm = new FrmNewFileCreator();
        FileForm:
            newFileForm.ShowDialog();

            if (newFileForm.DialogResult != DialogResult.OK)
            {
                return;
            }

            var fileId = Guid.NewGuid();
            var fileName = newFileForm.FileName;

            if (!CreateFile(fileId.ToString(), fileName, TreeFileType.Folder, selectedNode))
            {
                goto FileForm;
            }

            var treeNode = new TreeNodeExtented();
            treeNode.Name = fileId.ToString();
            treeNode.Text = fileName;
            treeNode.ImageIndex = 0;
            treeNode.SelectedImageIndex = 0;
            treeNode.FilePath = Path.Combine(selectedNode.FilePath, fileName);
            treeNode.FileType = Slang.IDE.Shared.Enumerations.TreeFileType.Folder;

            selectedNode.Nodes.Add(treeNode);
        }
        private void BtnNewSlangFile_Click(object sender, EventArgs e)
        {
            var selectedNode = this.FileExplorerTree.SelectedNode as TreeNodeExtented;

            if (selectedNode.FileType == Slang.IDE.Shared.Enumerations.TreeFileType.File)
            {
                selectedNode = selectedNode.Parent as TreeNodeExtented;
            }

            using var newFileForm = new FrmNewFileCreator();
        FileForm:
            newFileForm.ShowDialog();

            if (newFileForm.DialogResult != DialogResult.OK)
            {
                return;
            }

            var fileId = Guid.NewGuid();
            var fileName = newFileForm.FileName.EndsWith(".slang") ? newFileForm.FileName : $"{newFileForm.FileName}.slang";

            if (!CreateFile(fileId.ToString(), fileName, TreeFileType.File, selectedNode))
            {
                goto FileForm;
            }

            var treeNode = new TreeNodeExtented();
            treeNode.Name = fileId.ToString();
            treeNode.Text = fileName;
            treeNode.ImageIndex = 1;
            treeNode.SelectedImageIndex = 1;
            treeNode.FileType = Slang.IDE.Shared.Enumerations.TreeFileType.File;

            selectedNode.Nodes.Add(treeNode);

        }
        private bool CreateFile(string name, string text, TreeFileType fileType, TreeNodeExtented parent)
        {
            var path = Path.Combine(parent.FilePath, text);

            if (fileType == TreeFileType.File)
            {
                if (!File.Exists(path))
                {
                    File.Create(path).Close();
                }
                else
                {
                    MessageBox.Show("There is already a file with same name in this directory.");
                    return false;
                }
            }
            else
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                else
                {
                    MessageBox.Show("There is already a folder with same name in this directory.");
                    return false;
                }
            }

            Sessions.SlangProject.Files.Add(new Preferences.SlangProjectFiles
            {
                Id = Guid.Parse(name),
                Name = text,
                FilePath = path,
                FileType = fileType,
                ParentId = Guid.Parse(parent.Name),
            });

            Functions.UpdateProject();

            return true;
        }
        private void BtnRename_Click(object sender, EventArgs e)
        {
            var selectedNode = FileExplorerTree.SelectedNode as TreeNodeExtented;

            using var frmRename = new FrmRename(selectedNode.Text);
        RenameForm:
            frmRename.ShowDialog();

            if (frmRename.DialogResult != DialogResult.OK)
            {
                return;
            }

            var newFileName = string.Empty;
            var newPath = string.Empty;

            if (selectedNode.FileType == TreeFileType.Folder)
            {
                newFileName = frmRename.FileName;

                newPath = selectedNode.FilePath.Replace(selectedNode.Text, newFileName);
                if (Directory.Exists(newPath))
                {
                    MessageBox.Show("There is already a folder with same name in this directory.");
                    goto RenameForm;
                }

                Directory.Move(selectedNode.FilePath, newPath);
            }
            else
            {
                newFileName = frmRename.FileName.EndsWith(".slang") ? frmRename.FileName : frmRename.FileName + ".slang";

                newPath = selectedNode.FilePath.Replace(selectedNode.Text, newFileName);
                if (File.Exists(newPath))
                {
                    MessageBox.Show("There is already a file with same name in this directory.");
                    goto RenameForm;
                }

                File.Move(selectedNode.FilePath, newPath);
            }

            selectedNode.Text = newFileName;

            Sessions.SlangProject.Files.FirstOrDefault(x => x.Id == Guid.Parse(selectedNode.Name)).Name = newFileName;
            Sessions.SlangProject.Files.FirstOrDefault(x => x.Id == Guid.Parse(selectedNode.Name)).FilePath = newPath;

            Functions.UpdateProject();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var selectedNode = FileExplorerTree.SelectedNode as TreeNodeExtented;
            var selectedNodeFileType = selectedNode.FileType;
            var selectedNodeId = Guid.Parse(selectedNode.Name);


            if(selectedNodeFileType == TreeFileType.Solution)
            {
                MessageBox.Show("This action is prohibited.", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if(selectedNodeFileType == TreeFileType.Folder)
            {
                Directory.Delete(selectedNode.FilePath, true);
            }
            else
            {
                File.Delete(selectedNode.FilePath);
            }


            RemoveFromSession(selectedNodeId);
            Functions.UpdateProject();
            FileExplorerTree.Nodes.Remove(selectedNode);
        }

        private void RemoveFromSession(Guid selectedNodeId)
        {
            var nodes = Sessions.SlangProject.Files.Where(x=>x.ParentId == selectedNodeId).ToList().ToArray();

            if(nodes.Any())
            {
                foreach(var node in nodes)
                {
                    RemoveFromSession(node.Id);
                }
            }

            var removedNode = Sessions.SlangProject.Files.First(x => x.Id == selectedNodeId);
            Sessions.SlangProject.Files.Remove(removedNode);
        }

        private void BtnShowInFolder_Click(object sender, EventArgs e)
        {
            var selectedNode = FileExplorerTree.SelectedNode as TreeNodeExtented;
            var showPath = Directory.GetParent(selectedNode.FilePath).FullName;

            Process.Start(showPath);
        }
        #endregion


    }
}
