using IDE.Helper;
using System.Diagnostics;

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
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnToggleBookmark = new System.Windows.Forms.ToolStripButton();
            this.BtnDeleteAllBookmarks = new System.Windows.Forms.ToolStripButton();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.LblStatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblLineLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblLine = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblColumnText = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblColumn = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblPositionText = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblPosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.BlueTheme = new WeifenLuo.WinFormsUI.Docking.VS2015BlueTheme();
            this.DarkTheme = new WeifenLuo.WinFormsUI.Docking.VS2015DarkTheme();
            this.LightTheme = new WeifenLuo.WinFormsUI.Docking.VS2015LightTheme();
            this.MainDockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.EditorsTools.SuspendLayout();
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
            this.BtnDebug,
            this.toolStripSeparator3,
            this.BtnToggleBookmark,
            this.BtnDeleteAllBookmarks});
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
            this.BtnUndo.Text = "Undo";
            this.BtnUndo.ToolTipText = "Undo";
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
            this.BtnRun.Text = "Run Without Debugging";
            this.BtnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // BtnDebug
            // 
            this.BtnDebug.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnDebug.Image = global::IDE.Properties.Resources.debug;
            this.BtnDebug.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDebug.Name = "BtnDebug";
            this.BtnDebug.Size = new System.Drawing.Size(24, 24);
            this.BtnDebug.Text = "Debug";
            this.BtnDebug.Click += new System.EventHandler(this.BtnDebug_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // BtnToggleBookmark
            // 
            this.BtnToggleBookmark.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnToggleBookmark.Image = ((System.Drawing.Image)(resources.GetObject("BtnToggleBookmark.Image")));
            this.BtnToggleBookmark.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnToggleBookmark.Name = "BtnToggleBookmark";
            this.BtnToggleBookmark.Size = new System.Drawing.Size(24, 24);
            this.BtnToggleBookmark.Text = "Toggle Bookmark";
            this.BtnToggleBookmark.Click += new System.EventHandler(this.ToggleBookmark);
            // 
            // BtnDeleteAllBookmarks
            // 
            this.BtnDeleteAllBookmarks.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnDeleteAllBookmarks.Image = global::IDE.Properties.Resources.Bookmark_Delete_All;
            this.BtnDeleteAllBookmarks.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDeleteAllBookmarks.Name = "BtnDeleteAllBookmarks";
            this.BtnDeleteAllBookmarks.Size = new System.Drawing.Size(24, 24);
            this.BtnDeleteAllBookmarks.Text = "Delete all Bookmarks";
            this.BtnDeleteAllBookmarks.ToolTipText = "Delete all Bookmarks from all files";
            this.BtnDeleteAllBookmarks.Click += new System.EventHandler(this.DeleteAllBookmarks);
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
            this.LblColumn,
            this.LblPositionText,
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
            this.LblStatusMessage.Size = new System.Drawing.Size(0, 17);
            // 
            // LblLineLabel
            // 
            this.LblLineLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LblLineLabel.Name = "LblLineLabel";
            this.LblLineLabel.Size = new System.Drawing.Size(785, 17);
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
            // LblColumn
            // 
            this.LblColumn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LblColumn.Name = "LblColumn";
            this.LblColumn.Size = new System.Drawing.Size(13, 17);
            this.LblColumn.Text = "0";
            // 
            // LblPositionText
            // 
            this.LblPositionText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LblPositionText.Name = "LblPositionText";
            this.LblPositionText.Size = new System.Drawing.Size(29, 17);
            this.LblPositionText.Text = "Pos:";
            // 
            // LblPosition
            // 
            this.LblPosition.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LblPosition.Name = "LblPosition";
            this.LblPosition.Size = new System.Drawing.Size(13, 17);
            this.LblPosition.Text = "0";
            // 
            // MainDockPanel
            // 
            this.MainDockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainDockPanel.DockBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.MainDockPanel.Location = new System.Drawing.Point(0, 59);
            this.MainDockPanel.Name = "MainDockPanel";
            this.MainDockPanel.Padding = new System.Windows.Forms.Padding(6);
            this.MainDockPanel.ShowAutoHideContentOnHover = false;
            this.MainDockPanel.Size = new System.Drawing.Size(892, 573);
            this.MainDockPanel.TabIndex = 4;
            this.MainDockPanel.Theme = this.DarkTheme;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(474, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(892, 654);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MainDockPanel);
            this.Controls.Add(this.EditorsTools);
            this.Controls.Add(this.MainMenuStrip);
            this.Controls.Add(this.StatusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            this.EditorsTools.ResumeLayout(false);
            this.EditorsTools.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private ToolStrip EditorsTools;
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
        private ToolStripStatusLabel LblPositionText;
        private ToolStripStatusLabel LblPosition;
        private WeifenLuo.WinFormsUI.Docking.VS2015BlueTheme BlueTheme;
        private WeifenLuo.WinFormsUI.Docking.VS2015DarkTheme DarkTheme;
        private WeifenLuo.WinFormsUI.Docking.VS2015LightTheme LightTheme;
        private WeifenLuo.WinFormsUI.Docking.DockPanel MainDockPanel;
        private ToolStripStatusLabel LblColumnText;
        private ToolStripStatusLabel LblColumn;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton BtnToggleBookmark;
        private ToolStripButton BtnDeleteAllBookmarks;
        private Button button1;
    }
}