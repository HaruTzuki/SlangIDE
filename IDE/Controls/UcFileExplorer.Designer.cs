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
            this.TitleBanner = new System.Windows.Forms.Panel();
            this.LblTitle = new System.Windows.Forms.Label();
            this.FileExplorerTree = new System.Windows.Forms.TreeView();
            this.TreeViewContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BtnNewFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnNewSlangFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnRename = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnShowInFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageListFileExplorer = new System.Windows.Forms.ImageList(this.components);
            this.TitleBanner.SuspendLayout();
            this.TreeViewContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleBanner
            // 
            this.TitleBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.TitleBanner.Controls.Add(this.LblTitle);
            this.TitleBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBanner.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleBanner.Location = new System.Drawing.Point(0, 0);
            this.TitleBanner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TitleBanner.Name = "TitleBanner";
            this.TitleBanner.Size = new System.Drawing.Size(364, 36);
            this.TitleBanner.TabIndex = 0;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LblTitle.Location = new System.Drawing.Point(3, 10);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(95, 20);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "File Explorer";
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
            this.FileExplorerTree.Location = new System.Drawing.Point(0, 36);
            this.FileExplorerTree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FileExplorerTree.Name = "FileExplorerTree";
            this.FileExplorerTree.SelectedImageIndex = 0;
            this.FileExplorerTree.ShowLines = false;
            this.FileExplorerTree.Size = new System.Drawing.Size(364, 474);
            this.FileExplorerTree.TabIndex = 1;
            this.FileExplorerTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.FileExplorerTree_NodeMouseDoubleClick);
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
            this.TreeViewContextMenu.Size = new System.Drawing.Size(211, 164);
            // 
            // BtnNewFolder
            // 
            this.BtnNewFolder.Name = "BtnNewFolder";
            this.BtnNewFolder.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.BtnNewFolder.Size = new System.Drawing.Size(210, 24);
            this.BtnNewFolder.Text = "New Folder";
            this.BtnNewFolder.Click += new System.EventHandler(this.BtnNewFolder_Click);
            // 
            // newFileToolStripMenuItem
            // 
            this.newFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnNewSlangFile});
            this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            this.newFileToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.newFileToolStripMenuItem.Text = "New File";
            // 
            // BtnNewSlangFile
            // 
            this.BtnNewSlangFile.Name = "BtnNewSlangFile";
            this.BtnNewSlangFile.ShortcutKeyDisplayString = "";
            this.BtnNewSlangFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.BtnNewSlangFile.Size = new System.Drawing.Size(261, 26);
            this.BtnNewSlangFile.Text = "Slang File (.slang)";
            this.BtnNewSlangFile.Click += new System.EventHandler(this.BtnNewSlangFile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // BtnRename
            // 
            this.BtnRename.Name = "BtnRename";
            this.BtnRename.ShortcutKeyDisplayString = "";
            this.BtnRename.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F2)));
            this.BtnRename.Size = new System.Drawing.Size(210, 24);
            this.BtnRename.Text = "Rename";
            this.BtnRename.Click += new System.EventHandler(this.BtnRename_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.ShortcutKeyDisplayString = "Del";
            this.BtnDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.BtnDelete.Size = new System.Drawing.Size(210, 24);
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(207, 6);
            // 
            // BtnShowInFolder
            // 
            this.BtnShowInFolder.Name = "BtnShowInFolder";
            this.BtnShowInFolder.Size = new System.Drawing.Size(210, 24);
            this.BtnShowInFolder.Text = "Show in folder";
            this.BtnShowInFolder.Click += new System.EventHandler(this.BtnShowInFolder_Click);
            // 
            // ImageListFileExplorer
            // 
            this.ImageListFileExplorer.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageListFileExplorer.ImageStream")));
            this.ImageListFileExplorer.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageListFileExplorer.Images.SetKeyName(0, "FolderOpened.png");
            this.ImageListFileExplorer.Images.SetKeyName(1, "CSFile.png");
            // 
            // UcFileExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FileExplorerTree);
            this.Controls.Add(this.TitleBanner);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UcFileExplorer";
            this.Size = new System.Drawing.Size(364, 510);
            this.TitleBanner.ResumeLayout(false);
            this.TitleBanner.PerformLayout();
            this.TreeViewContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel TitleBanner;
        private Label LblTitle;
        private TreeView FileExplorerTree;
        private ContextMenuStrip TreeViewContextMenu;
        private ToolStripMenuItem BtnNewFolder;
        private ToolStripMenuItem newFileToolStripMenuItem;
        private ToolStripMenuItem BtnNewSlangFile;
        private ImageList ImageListFileExplorer;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem BtnRename;
        private ToolStripMenuItem BtnDelete;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem BtnShowInFolder;
    }
}
