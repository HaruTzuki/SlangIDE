using IDE.Helper;
using IDE.Views;
using System.Data;

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
            this.treeView1.Nodes.Clear();

            var root = new TreeNode();
            root.Name = Sessions.SlangProject.Id.ToString();
            root.Text = Sessions.SlangProject.Name;

            this.treeView1.Nodes.Add(root);

            // Gets without parents
            var withoutParents = Sessions.SlangProject.Files.Where(x => x.ParentId is null);
            foreach (var withoutParent in withoutParents)
            {
                var _object = new TreeNode();
                _object.Name = withoutParent.Id.ToString();
                _object.Text = withoutParent.Name;
                _object.ImageIndex = 0;
                root.Nodes.Add(_object);
            }

            var withParents = Sessions.SlangProject.Files.Where(x => x.ParentId is not null);

            foreach (var withParent in withParents)
            {
                var parentNode = this.treeView1.Nodes.Find(withParent.ParentId.ToString(), true).First();
                var _object = new TreeNode();
                _object.Name = withParent.Id.ToString();
                _object.Text = withParent.Name;
                _object.ImageIndex = 1;
                parentNode.Nodes.Add(_object);
            }

            this.treeView1.ExpandAll();

        }


        private void BtnNewFolder_Click(object sender, EventArgs e)
        {
            var selectedNode = this.treeView1.SelectedNode;
            selectedNode.Nodes.Add("_newfolder", "New Folder", 0);
        }

        private void BtnNewSlangFile_Click(object sender, EventArgs e)
        {
            var selectedNode = this.treeView1.SelectedNode;
            selectedNode.Nodes.Add("_newfile", "New File", 1);
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            Console.WriteLine(e.Node.Name);
            var file = Sessions.SlangProject.Files.FirstOrDefault(x => x.Id == Guid.Parse(e.Node.Name));

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
    }
}
