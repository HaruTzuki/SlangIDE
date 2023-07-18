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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.PanelContainer = new System.Windows.Forms.SplitContainer();
            this.FileExplorer = new IDE.Controls.UcFileExplorer();
            this.CustomUI = new IDE.Helper.Custom.CustomUI();
            this.BtnRun = new System.Windows.Forms.ToolStripButton();
            this.BtnUndo = new System.Windows.Forms.ToolStripButton();
            this.BtnRedo = new System.Windows.Forms.ToolStripButton();
            this.BtnSave = new System.Windows.Forms.ToolStripButton();
            this.BtnSaveAll = new System.Windows.Forms.ToolStripButton();
            this.BtnDebug = new System.Windows.Forms.ToolStripButton();
            this.EditorsTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelContainer)).BeginInit();
            this.PanelContainer.Panel1.SuspendLayout();
            this.PanelContainer.SuspendLayout();
            this.CustomUI.ContentsPanel.SuspendLayout();
            this.CustomUI.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditorsTools
            // 
            this.EditorsTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.EditorsTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnUndo,
            this.BtnRedo,
            this.toolStripSeparator1,
            this.BtnSave,
            this.BtnSaveAll,
            this.toolStripSeparator2,
            this.BtnDebug,
            this.BtnRun});
            this.EditorsTools.Location = new System.Drawing.Point(0, 0);
            this.EditorsTools.Name = "EditorsTools";
            this.EditorsTools.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.EditorsTools.Size = new System.Drawing.Size(694, 25);
            this.EditorsTools.TabIndex = 2;
            this.EditorsTools.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // PanelContainer
            // 
            this.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContainer.Location = new System.Drawing.Point(0, 25);
            this.PanelContainer.Name = "PanelContainer";
            // 
            // PanelContainer.Panel1
            // 
            this.PanelContainer.Panel1.Controls.Add(this.FileExplorer);
            this.PanelContainer.Size = new System.Drawing.Size(694, 359);
            this.PanelContainer.SplitterDistance = 122;
            this.PanelContainer.SplitterWidth = 3;
            this.PanelContainer.TabIndex = 2;
            // 
            // FileExplorer
            // 
            this.FileExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileExplorer.Location = new System.Drawing.Point(0, 0);
            this.FileExplorer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FileExplorer.Name = "FileExplorer";
            this.FileExplorer.Size = new System.Drawing.Size(122, 359);
            this.FileExplorer.TabIndex = 0;
            // 
            // CustomUI
            // 
            this.CustomUI.AllowMaximize = true;
            this.CustomUI.AllowMinimize = true;
            this.CustomUI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            // 
            // CustomUI.ContentsPanel
            // 
            this.CustomUI.ContentsPanel.Controls.Add(this.PanelContainer);
            this.CustomUI.ContentsPanel.Controls.Add(this.EditorsTools);
            this.CustomUI.ContentsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomUI.ContentsPanel.Enabled = true;
            this.CustomUI.ContentsPanel.Location = new System.Drawing.Point(0, 28);
            this.CustomUI.ContentsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.CustomUI.ContentsPanel.Name = "ContentsPanel";
            this.CustomUI.ContentsPanel.Size = new System.Drawing.Size(694, 384);
            this.CustomUI.ContentsPanel.TabIndex = 1;
            this.CustomUI.ContentsPanel.Visible = true;
            this.CustomUI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomUI.FormClosingOperation = IDE.Helper.Custom.FormClosingOperations.CloseApplication;
            this.CustomUI.Location = new System.Drawing.Point(5, 5);
            this.CustomUI.Margin = new System.Windows.Forms.Padding(2);
            this.CustomUI.Name = "CustomUI";
            this.CustomUI.Size = new System.Drawing.Size(694, 412);
            this.CustomUI.TabIndex = 0;
            this.CustomUI.Title = "%%";
            // 
            // BtnRun
            // 
            this.BtnRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnRun.Image = global::IDE.Properties.Resources.ASX_Run_blue_16x;
            this.BtnRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnRun.Name = "BtnRun";
            this.BtnRun.Size = new System.Drawing.Size(23, 22);
            this.BtnRun.Text = "toolStripButton1";
            // 
            // BtnUndo
            // 
            this.BtnUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnUndo.Image = global::IDE.Properties.Resources.Undo_16x;
            this.BtnUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnUndo.Name = "BtnUndo";
            this.BtnUndo.Size = new System.Drawing.Size(23, 22);
            this.BtnUndo.Text = "toolStripButton1";
            // 
            // BtnRedo
            // 
            this.BtnRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnRedo.Image = global::IDE.Properties.Resources.Redo_16x;
            this.BtnRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnRedo.Name = "BtnRedo";
            this.BtnRedo.Size = new System.Drawing.Size(23, 22);
            this.BtnRedo.Text = "toolStripButton2";
            // 
            // BtnSave
            // 
            this.BtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnSave.Image = global::IDE.Properties.Resources.Save_16x;
            this.BtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(23, 22);
            this.BtnSave.Text = "toolStripButton1";
            // 
            // BtnSaveAll
            // 
            this.BtnSaveAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnSaveAll.Image = global::IDE.Properties.Resources.SaveAll_16x;
            this.BtnSaveAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSaveAll.Name = "BtnSaveAll";
            this.BtnSaveAll.Size = new System.Drawing.Size(23, 22);
            this.BtnSaveAll.Text = "toolStripButton2";
            // 
            // BtnDebug
            // 
            this.BtnDebug.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnDebug.Image = global::IDE.Properties.Resources.Run_16x;
            this.BtnDebug.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDebug.Name = "BtnDebug";
            this.BtnDebug.Size = new System.Drawing.Size(23, 22);
            this.BtnDebug.Text = "toolStripButton1";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 422);
            this.Controls.Add(this.CustomUI);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMain";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.EditorsTools.ResumeLayout(false);
            this.EditorsTools.PerformLayout();
            this.PanelContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelContainer)).EndInit();
            this.PanelContainer.ResumeLayout(false);
            this.CustomUI.ContentsPanel.ResumeLayout(false);
            this.CustomUI.ContentsPanel.PerformLayout();
            this.CustomUI.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion


        private ToolStrip EditorsTools;
        private SplitContainer PanelContainer;
        private Controls.UcFileExplorer FileExplorer;
        private Helper.Custom.CustomUI CustomUI;
        private ToolStripButton BtnUndo;
        private ToolStripButton BtnRedo;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton BtnSave;
        private ToolStripButton BtnSaveAll;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton BtnDebug;
        private ToolStripButton BtnRun;
    }
}