namespace IDE.Views.ToolWindows
{
    partial class ToolWindowBookmarks
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
            BrightIdeasSoftware.HeaderStateStyle headerStateStyle4 = new BrightIdeasSoftware.HeaderStateStyle();
            BrightIdeasSoftware.HeaderStateStyle headerStateStyle5 = new BrightIdeasSoftware.HeaderStateStyle();
            BrightIdeasSoftware.HeaderStateStyle headerStateStyle6 = new BrightIdeasSoftware.HeaderStateStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolWindowBookmarks));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnToggleBookmark = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnDeleteBookmark = new System.Windows.Forms.ToolStripButton();
            this.headerFormatStyle1 = new BrightIdeasSoftware.HeaderFormatStyle();
            this.BookmarkListView = new System.Windows.Forms.ListView();
            this.BookmarkColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LineNumberColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnToggleBookmark,
            this.toolStripSeparator1,
            this.BtnDeleteBookmark});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(569, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnToggleBookmark
            // 
            this.BtnToggleBookmark.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnToggleBookmark.Image = global::IDE.Properties.Resources.Bookmark_Insert;
            this.BtnToggleBookmark.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnToggleBookmark.Name = "BtnToggleBookmark";
            this.BtnToggleBookmark.Size = new System.Drawing.Size(23, 22);
            this.BtnToggleBookmark.Text = "toolStripButton1";
            this.BtnToggleBookmark.ToolTipText = "Toggle Bookmark";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // BtnDeleteBookmark
            // 
            this.BtnDeleteBookmark.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnDeleteBookmark.Image = global::IDE.Properties.Resources.Bookmark_Delete;
            this.BtnDeleteBookmark.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDeleteBookmark.Name = "BtnDeleteBookmark";
            this.BtnDeleteBookmark.Size = new System.Drawing.Size(23, 22);
            this.BtnDeleteBookmark.Text = "toolStripButton2";
            this.BtnDeleteBookmark.ToolTipText = "Delete Bookmark";
            // 
            // headerFormatStyle1
            // 
            headerStateStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            headerStateStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            headerStateStyle4.FrameColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.headerFormatStyle1.Hot = headerStateStyle4;
            headerStateStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            headerStateStyle5.ForeColor = System.Drawing.Color.WhiteSmoke;
            headerStateStyle5.FrameColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.headerFormatStyle1.Normal = headerStateStyle5;
            headerStateStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            headerStateStyle6.ForeColor = System.Drawing.Color.WhiteSmoke;
            headerStateStyle6.FrameColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.headerFormatStyle1.Pressed = headerStateStyle6;
            // 
            // BookmarkListView
            // 
            this.BookmarkListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BookmarkListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BookmarkColumn,
            this.FileColumn,
            this.LineNumberColumn});
            this.BookmarkListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BookmarkListView.HideSelection = false;
            this.BookmarkListView.Location = new System.Drawing.Point(0, 25);
            this.BookmarkListView.Name = "BookmarkListView";
            this.BookmarkListView.Size = new System.Drawing.Size(569, 263);
            this.BookmarkListView.TabIndex = 1;
            this.BookmarkListView.UseCompatibleStateImageBehavior = false;
            this.BookmarkListView.View = System.Windows.Forms.View.Details;
            // 
            // BookmarkColumn
            // 
            this.BookmarkColumn.Text = "Bookmark";
            this.BookmarkColumn.Width = 150;
            // 
            // FileColumn
            // 
            this.FileColumn.Text = "File Location";
            this.FileColumn.Width = 300;
            // 
            // LineNumberColumn
            // 
            this.LineNumberColumn.Text = "Line Number";
            this.LineNumberColumn.Width = 100;
            // 
            // ToolWindowBookmarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 288);
            this.Controls.Add(this.BookmarkListView);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ToolWindowBookmarks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "Bookmarks";
            this.Text = "Bookmarks";
            this.Load += new System.EventHandler(this.ToolWindowBookmarks_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton BtnToggleBookmark;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton BtnDeleteBookmark;
        private BrightIdeasSoftware.HeaderFormatStyle headerFormatStyle1;
        private ListView BookmarkListView;
        private ColumnHeader BookmarkColumn;
        private ColumnHeader FileColumn;
        private ColumnHeader LineNumberColumn;
    }
}