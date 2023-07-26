namespace IDE.Views
{
    partial class FrmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EditorsTools = new System.Windows.Forms.ToolStrip();
            this.BtnUndo = new System.Windows.Forms.ToolStripButton();
            this.BtnRedo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnSave = new System.Windows.Forms.ToolStripButton();
            this.BtnSaveAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnDebug = new System.Windows.Forms.ToolStripButton();
            this.BtnRun = new System.Windows.Forms.ToolStripButton();
            this.PanelContainer = new System.Windows.Forms.SplitContainer();
            this.FileExplorer = new IDE.Controls.UcFileExplorer();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.EditorsTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelContainer)).BeginInit();
            this.PanelContainer.Panel1.SuspendLayout();
            this.PanelContainer.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditorsTools
            // 
            this.EditorsTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.EditorsTools.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.EditorsTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnUndo,
            this.BtnRedo,
            this.toolStripSeparator1,
            this.BtnSave,
            this.BtnSaveAll,
            this.toolStripSeparator2,
            this.BtnDebug,
            this.BtnRun});
            this.EditorsTools.Location = new System.Drawing.Point(0, 24);
            this.EditorsTools.Name = "EditorsTools";
            this.EditorsTools.Padding = new System.Windows.Forms.Padding(5);
            this.EditorsTools.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.EditorsTools.Size = new System.Drawing.Size(1190, 37);
            this.EditorsTools.TabIndex = 2;
            this.EditorsTools.Text = "toolStrip1";
            // 
            // BtnUndo
            // 
            this.BtnUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnUndo.Image = global::IDE.Properties.Resources.Undo_16x;
            this.BtnUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnUndo.Name = "BtnUndo";
            this.BtnUndo.Size = new System.Drawing.Size(29, 24);
            this.BtnUndo.Text = "toolStripButton1";
            // 
            // BtnRedo
            // 
            this.BtnRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnRedo.Image = global::IDE.Properties.Resources.Redo_16x;
            this.BtnRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnRedo.Name = "BtnRedo";
            this.BtnRedo.Size = new System.Drawing.Size(29, 24);
            this.BtnRedo.Text = "toolStripButton2";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // BtnSave
            // 
            this.BtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnSave.Image = global::IDE.Properties.Resources.Save_16x;
            this.BtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(29, 24);
            this.BtnSave.Text = "Save";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnSaveAll
            // 
            this.BtnSaveAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnSaveAll.Image = global::IDE.Properties.Resources.SaveAll_16x;
            this.BtnSaveAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSaveAll.Name = "BtnSaveAll";
            this.BtnSaveAll.Size = new System.Drawing.Size(29, 24);
            this.BtnSaveAll.Text = "Save All";
            this.BtnSaveAll.Click += new System.EventHandler(this.BtnSaveAll_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // BtnDebug
            // 
            this.BtnDebug.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnDebug.Image = global::IDE.Properties.Resources.Run_16x;
            this.BtnDebug.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDebug.Name = "BtnDebug";
            this.BtnDebug.Size = new System.Drawing.Size(29, 24);
            this.BtnDebug.Text = "toolStripButton1";
            // 
            // BtnRun
            // 
            this.BtnRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnRun.Image = global::IDE.Properties.Resources.ASX_Run_blue_16x;
            this.BtnRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnRun.Name = "BtnRun";
            this.BtnRun.Size = new System.Drawing.Size(29, 24);
            this.BtnRun.Text = "toolStripButton1";
            // 
            // PanelContainer
            // 
            this.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContainer.Location = new System.Drawing.Point(0, 61);
            this.PanelContainer.Name = "PanelContainer";
            // 
            // PanelContainer.Panel1
            // 
            this.PanelContainer.Panel1.Controls.Add(this.FileExplorer);
            this.PanelContainer.Size = new System.Drawing.Size(1190, 720);
            this.PanelContainer.SplitterDistance = 209;
            this.PanelContainer.SplitterWidth = 3;
            this.PanelContainer.TabIndex = 2;
            // 
            // FileExplorer
            // 
            this.FileExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileExplorer.Location = new System.Drawing.Point(0, 0);
            this.FileExplorer.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.FileExplorer.Name = "FileExplorer";
            this.FileExplorer.Size = new System.Drawing.Size(209, 720);
            this.FileExplorer.TabIndex = 0;
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.MainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Padding = new System.Windows.Forms.Padding(5);
            this.MainMenuStrip.Size = new System.Drawing.Size(1190, 24);
            this.MainMenuStrip.TabIndex = 3;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 781);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1190, 24);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1190, 805);
            this.Controls.Add(this.PanelContainer);
            this.Controls.Add(this.EditorsTools);
            this.Controls.Add(this.MainMenuStrip);
            this.Controls.Add(this.statusStrip1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.EditorsTools.ResumeLayout(false);
            this.EditorsTools.PerformLayout();
            this.PanelContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelContainer)).EndInit();
            this.PanelContainer.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private ToolStrip EditorsTools;
        private SplitContainer PanelContainer;
        private Controls.UcFileExplorer FileExplorer;
        private ToolStripButton BtnUndo;
        private ToolStripButton BtnRedo;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton BtnSave;
        private ToolStripButton BtnSaveAll;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton BtnDebug;
        private ToolStripButton BtnRun;
        private MenuStrip MainMenuStrip;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar toolStripProgressBar1;
    }
}