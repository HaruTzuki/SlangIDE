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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcFileExplorer));
            panel1 = new Panel();
            label1 = new Label();
            treeView1 = new TreeView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            BtnNewFolder = new ToolStripMenuItem();
            newFileToolStripMenuItem = new ToolStripMenuItem();
            BtnNewSlangFile = new ToolStripMenuItem();
            ImageListFileExplorer = new ImageList(components);
            panel1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 25, 25);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(364, 45);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 12);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "File Explorer";
            // 
            // treeView1
            // 
            treeView1.BackColor = Color.FromArgb(37, 37, 37);
            treeView1.BorderStyle = BorderStyle.None;
            treeView1.ContextMenuStrip = contextMenuStrip1;
            treeView1.Dock = DockStyle.Fill;
            treeView1.ForeColor = Color.White;
            treeView1.ImageIndex = 0;
            treeView1.ImageList = ImageListFileExplorer;
            treeView1.Location = new Point(0, 45);
            treeView1.Name = "treeView1";
            treeView1.SelectedImageIndex = 0;
            treeView1.ShowLines = false;
            treeView1.Size = new Size(364, 592);
            treeView1.TabIndex = 1;
            treeView1.NodeMouseDoubleClick += treeView1_NodeMouseDoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { BtnNewFolder, newFileToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(155, 52);
            // 
            // BtnNewFolder
            // 
            BtnNewFolder.Name = "BtnNewFolder";
            BtnNewFolder.Size = new Size(154, 24);
            BtnNewFolder.Text = "New Folder";
            BtnNewFolder.Click += BtnNewFolder_Click;
            // 
            // newFileToolStripMenuItem
            // 
            newFileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { BtnNewSlangFile });
            newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            newFileToolStripMenuItem.Size = new Size(154, 24);
            newFileToolStripMenuItem.Text = "New File";
            // 
            // BtnNewSlangFile
            // 
            BtnNewSlangFile.Name = "BtnNewSlangFile";
            BtnNewSlangFile.Size = new Size(208, 26);
            BtnNewSlangFile.Text = "Slang File (.slang)";
            BtnNewSlangFile.Click += BtnNewSlangFile_Click;
            // 
            // ImageListFileExplorer
            // 
            ImageListFileExplorer.ColorDepth = ColorDepth.Depth8Bit;
            ImageListFileExplorer.ImageStream = (ImageListStreamer)resources.GetObject("ImageListFileExplorer.ImageStream");
            ImageListFileExplorer.TransparentColor = Color.Transparent;
            ImageListFileExplorer.Images.SetKeyName(0, "FolderOpened.png");
            ImageListFileExplorer.Images.SetKeyName(1, "CSFile.png");
            // 
            // UcFileExplorer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(treeView1);
            Controls.Add(panel1);
            Name = "UcFileExplorer";
            Size = new Size(364, 637);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TreeView treeView1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem BtnNewFolder;
        private ToolStripMenuItem newFileToolStripMenuItem;
        private ToolStripMenuItem BtnNewSlangFile;
        private ImageList ImageListFileExplorer;
    }
}
