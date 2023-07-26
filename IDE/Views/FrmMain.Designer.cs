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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.EditorsTools = new System.Windows.Forms.ToolStrip();
            this.BtnUndo = new System.Windows.Forms.ToolStripButton();
            this.BtnRedo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnSave = new System.Windows.Forms.ToolStripButton();
            this.BtnSaveAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnRun = new System.Windows.Forms.ToolStripButton();
            this.BtnDebug = new System.Windows.Forms.ToolStripButton();
            this.PanelContainer = new System.Windows.Forms.SplitContainer();
            this.FileExplorer = new IDE.Controls.UcFileExplorer();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.LblStatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblLineLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblLine = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblColumnText = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblPosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.EditorsTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelContainer)).BeginInit();
            this.PanelContainer.Panel1.SuspendLayout();
            this.PanelContainer.SuspendLayout();
            this.StatusStrip.SuspendLayout();
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
            this.BtnRun,
            this.BtnDebug});
            this.EditorsTools.Location = new System.Drawing.Point(0, 24);
            this.EditorsTools.Name = "EditorsTools";
            this.EditorsTools.Padding = new System.Windows.Forms.Padding(4);
            this.EditorsTools.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.EditorsTools.Size = new System.Drawing.Size(892, 35);
            this.EditorsTools.TabIndex = 2;
            this.EditorsTools.Text = "toolStrip1";
            // 
            // BtnUndo
            // 
            this.BtnUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnUndo.Image = ((System.Drawing.Image)(resources.GetObject("BtnUndo.Image")));
            this.BtnUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnUndo.Name = "BtnUndo";
            this.BtnUndo.Size = new System.Drawing.Size(24, 24);
            this.BtnUndo.Click += new System.EventHandler(this.BtnUndo_Click);
            // 
            // BtnRedo
            // 
            this.BtnRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnRedo.Image = global::IDE.Properties.Resources.redo;
            this.BtnRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnRedo.Name = "BtnRedo";
            this.BtnRedo.Size = new System.Drawing.Size(24, 24);
            this.BtnRedo.Text = "Redo";
            this.BtnRedo.Click += new System.EventHandler(this.BtnRedo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // BtnSave
            // 
            this.BtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnSave.Image = global::IDE.Properties.Resources.save;
            this.BtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(24, 24);
            this.BtnSave.Text = "Save";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnSaveAll
            // 
            this.BtnSaveAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnSaveAll.Image = ((System.Drawing.Image)(resources.GetObject("BtnSaveAll.Image")));
            this.BtnSaveAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSaveAll.Name = "BtnSaveAll";
            this.BtnSaveAll.Size = new System.Drawing.Size(24, 24);
            this.BtnSaveAll.Text = "Save All";
            this.BtnSaveAll.Click += new System.EventHandler(this.BtnSaveAll_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // BtnRun
            // 
            this.BtnRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnRun.Image = global::IDE.Properties.Resources.run;
            this.BtnRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnRun.Name = "BtnRun";
            this.BtnRun.Size = new System.Drawing.Size(24, 24);
            this.BtnRun.Text = "toolStripButton1";
            // 
            // BtnDebug
            // 
            this.BtnDebug.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnDebug.Image = global::IDE.Properties.Resources.debug;
            this.BtnDebug.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDebug.Name = "BtnDebug";
            this.BtnDebug.Size = new System.Drawing.Size(24, 24);
            this.BtnDebug.Text = "toolStripButton1";
            // 
            // PanelContainer
            // 
            this.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContainer.Location = new System.Drawing.Point(0, 59);
            this.PanelContainer.Margin = new System.Windows.Forms.Padding(2);
            this.PanelContainer.Name = "PanelContainer";
            // 
            // PanelContainer.Panel1
            // 
            this.PanelContainer.Panel1.Controls.Add(this.FileExplorer);
            this.PanelContainer.Size = new System.Drawing.Size(892, 573);
            this.PanelContainer.SplitterDistance = 156;
            this.PanelContainer.SplitterWidth = 2;
            this.PanelContainer.TabIndex = 2;
            // 
            // FileExplorer
            // 
            this.FileExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileExplorer.Location = new System.Drawing.Point(0, 0);
            this.FileExplorer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FileExplorer.Name = "FileExplorer";
            this.FileExplorer.Size = new System.Drawing.Size(156, 573);
            this.FileExplorer.TabIndex = 0;
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.MainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Padding = new System.Windows.Forms.Padding(4);
            this.MainMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MainMenuStrip.Size = new System.Drawing.Size(892, 24);
            this.MainMenuStrip.TabIndex = 3;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // StatusStrip
            // 
            this.StatusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(136)))), ((int)(((byte)(217)))));
            this.StatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusProgress,
            this.LblStatusMessage,
            this.LblLineLabel,
            this.LblLine,
            this.LblColumnText,
            this.LblPosition});
            this.StatusStrip.Location = new System.Drawing.Point(0, 632);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.StatusStrip.Size = new System.Drawing.Size(892, 22);
            this.StatusStrip.SizingGrip = false;
            this.StatusStrip.TabIndex = 1;
            // 
            // StatusProgress
            // 
            this.StatusProgress.Name = "StatusProgress";
            this.StatusProgress.Size = new System.Drawing.Size(75, 16);
            this.StatusProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.StatusProgress.Visible = false;
            // 
            // LblStatusMessage
            // 
            this.LblStatusMessage.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LblStatusMessage.Name = "LblStatusMessage";
            this.LblStatusMessage.Size = new System.Drawing.Size(13, 17);
            this.LblStatusMessage.Text = "0";
            this.LblStatusMessage.Visible = false;
            // 
            // LblLineLabel
            // 
            this.LblLineLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LblLineLabel.Name = "LblLineLabel";
            this.LblLineLabel.Size = new System.Drawing.Size(827, 17);
            this.LblLineLabel.Spring = true;
            this.LblLineLabel.Text = "Line:";
            this.LblLineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblLine
            // 
            this.LblLine.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LblLine.Name = "LblLine";
            this.LblLine.Size = new System.Drawing.Size(13, 17);
            this.LblLine.Text = "0";
            // 
            // LblColumnText
            // 
            this.LblColumnText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LblColumnText.Name = "LblColumnText";
            this.LblColumnText.Size = new System.Drawing.Size(28, 17);
            this.LblColumnText.Text = "Col:";
            // 
            // LblPosition
            // 
            this.LblPosition.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LblPosition.Name = "LblPosition";
            this.LblPosition.Size = new System.Drawing.Size(13, 17);
            this.LblPosition.Text = "0";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(892, 654);
            this.Controls.Add(this.PanelContainer);
            this.Controls.Add(this.EditorsTools);
            this.Controls.Add(this.MainMenuStrip);
            this.Controls.Add(this.StatusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
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
        private ToolStripButton BtnRun;
        private ToolStripButton BtnDebug;
        private MenuStrip MainMenuStrip;
        private StatusStrip StatusStrip;
        private ToolStripProgressBar StatusProgress;
        private ToolStripStatusLabel LblLineLabel;
        private ToolStripStatusLabel LblStatusMessage;
        private ToolStripStatusLabel LblLine;
        private ToolStripStatusLabel LblColumnText;
        private ToolStripStatusLabel LblPosition;
    }
}