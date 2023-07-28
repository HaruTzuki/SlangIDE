namespace IDE.Controls
{
    partial class UcFileExplorer
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcFileExplorer));
            this.FileExplorerTree = new System.Windows.Forms.TreeView();
            this.TreeViewContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BtnNewFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnNewSlangFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new IDE.Controls.DarkThemeToolStripSeparator();
            this.BtnRename = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new IDE.Controls.DarkThemeToolStripSeparator();
            this.BtnShowInFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageListFileExplorer = new System.Windows.Forms.ImageList(this.components);
            this.TreeViewContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileExplorerTree
            // 
            this.FileExplorerTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.FileExplorerTree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FileExplorerTree.ContextMenuStrip = this.TreeViewContextMenu;
            this.FileExplorerTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileExplorerTree.ForeColor = System.Drawing.Color.White;
            this.FileExplorerTree.ImageIndex = 0;
            this.FileExplorerTree.ImageList = this.ImageListFileExplorer;
            this.FileExplorerTree.Location = new System.Drawing.Point(0, 0);
            this.FileExplorerTree.Margin = new System.Windows.Forms.Padding(2);
            this.FileExplorerTree.Name = "FileExplorerTree";
            this.FileExplorerTree.SelectedImageIndex = 0;
            this.FileExplorerTree.ShowLines = false;
            this.FileExplorerTree.Size = new System.Drawing.Size(257, 375);
            this.FileExplorerTree.TabIndex = 1;
            // 
            // TreeViewContextMenu
            // 
            this.TreeViewContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TreeViewContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnNewFolder,
            this.newFileToolStripMenuItem,
            this.toolStripSeparator1,
            this.BtnRename,
            this.BtnDelete,
            this.toolStripSeparator2,
            this.BtnShowInFolder});
            this.TreeViewContextMenu.Name = "contextMenuStrip1";
            this.TreeViewContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.TreeViewContextMenu.Size = new System.Drawing.Size(177, 126);
            // 
            // BtnNewFolder
            // 
            this.BtnNewFolder.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnNewFolder.Name = "BtnNewFolder";
            this.BtnNewFolder.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.BtnNewFolder.Size = new System.Drawing.Size(176, 22);
            this.BtnNewFolder.Text = "New Folder";
            this.BtnNewFolder.Click += new System.EventHandler(this.BtnNewFolder_Click);
            // 
            // newFileToolStripMenuItem
            // 
            this.newFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnNewSlangFile});
            this.newFileToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            this.newFileToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.newFileToolStripMenuItem.Text = "New File";
            // 
            // BtnNewSlangFile
            // 
            this.BtnNewSlangFile.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnNewSlangFile.Name = "BtnNewSlangFile";
            this.BtnNewSlangFile.ShortcutKeyDisplayString = "";
            this.BtnNewSlangFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.BtnNewSlangFile.Size = new System.Drawing.Size(209, 22);
            this.BtnNewSlangFile.Text = "Slang File (.slang)";
            this.BtnNewSlangFile.Click += new System.EventHandler(this.BtnNewSlangFile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(173, 6);
            // 
            // BtnRename
            // 
            this.BtnRename.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnRename.Name = "BtnRename";
            this.BtnRename.ShortcutKeyDisplayString = "";
            this.BtnRename.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F2)));
            this.BtnRename.Size = new System.Drawing.Size(176, 22);
            this.BtnRename.Text = "Rename";
            this.BtnRename.Click += new System.EventHandler(this.BtnRename_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.ShortcutKeyDisplayString = "Del";
            this.BtnDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.BtnDelete.Size = new System.Drawing.Size(176, 22);
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(173, 6);
            // 
            // BtnShowInFolder
            // 
            this.BtnShowInFolder.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnShowInFolder.Name = "BtnShowInFolder";
            this.BtnShowInFolder.Size = new System.Drawing.Size(176, 22);
            this.BtnShowInFolder.Text = "Show in folder";
            this.BtnShowInFolder.Click += new System.EventHandler(this.BtnShowInFolder_Click);
            // 
            // ImageListFileExplorer
            // 
            this.ImageListFileExplorer.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageListFileExplorer.ImageStream")));
            this.ImageListFileExplorer.TransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ImageListFileExplorer.Images.SetKeyName(0, "folder.png");
            this.ImageListFileExplorer.Images.SetKeyName(1, "folder-open.png");
            this.ImageListFileExplorer.Images.SetKeyName(2, "file-code.png");
            this.ImageListFileExplorer.Images.SetKeyName(3, "file_code.png");
            this.ImageListFileExplorer.Images.SetKeyName(4, "CSFile.png");
            this.ImageListFileExplorer.Images.SetKeyName(5, "FolderOpened.png");
            this.ImageListFileExplorer.Images.SetKeyName(6, "slangproject.png");
            // 
            // UcFileExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 375);
            this.Controls.Add(this.FileExplorerTree);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UcFileExplorer";
            this.TabText = "File Explorer";
            this.Text = "File Explorer";
            this.TreeViewContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ContextMenuStrip TreeViewContextMenu;
        private ToolStripMenuItem BtnNewFolder;
        private ToolStripMenuItem newFileToolStripMenuItem;
        private ToolStripMenuItem BtnNewSlangFile;
        private ImageList ImageListFileExplorer;
        private ToolStripMenuItem BtnRename;
        private ToolStripMenuItem BtnDelete;
        private ToolStripMenuItem BtnShowInFolder;
        public TreeView FileExplorerTree;
        private DarkThemeToolStripSeparator toolStripSeparator1;
        private DarkThemeToolStripSeparator toolStripSeparator2;
    }
}
