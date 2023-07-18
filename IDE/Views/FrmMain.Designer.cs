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
            this.PanelContainer = new System.Windows.Forms.SplitContainer();
            this.FileExplorer = new IDE.Controls.UcFileExplorer();
            this.CustomUI = new IDE.Helper.Custom.CustomUI();
            ((System.ComponentModel.ISupportInitialize)(this.PanelContainer)).BeginInit();
            this.PanelContainer.Panel1.SuspendLayout();
            this.PanelContainer.SuspendLayout();
            this.CustomUI.ContentsPanel.SuspendLayout();
            this.CustomUI.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditorsTools
            // 
            this.EditorsTools.Location = new System.Drawing.Point(0, 0);
            this.EditorsTools.Name = "EditorsTools";
            this.EditorsTools.Size = new System.Drawing.Size(694, 25);
            this.EditorsTools.TabIndex = 2;
            this.EditorsTools.Text = "toolStrip1";
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
            this.PanelContainer.SplitterDistance = 231;
            this.PanelContainer.SplitterWidth = 3;
            this.PanelContainer.TabIndex = 2;
            // 
            // FileExplorer
            // 
            this.FileExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileExplorer.Location = new System.Drawing.Point(0, 0);
            this.FileExplorer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FileExplorer.Name = "FileExplorer";
            this.FileExplorer.Size = new System.Drawing.Size(231, 359);
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
    }
}