namespace IDE.Helper.Custom
{
    partial class CustomUI
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
            this.HeaderBar = new System.Windows.Forms.Panel();
            this.HeaderPanelTable = new System.Windows.Forms.TableLayoutPanel();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.HeaderTitle = new System.Windows.Forms.ToolStripLabel();
            this.BtnMinimize = new System.Windows.Forms.Button();
            this.BtnMaximize = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.Body = new System.Windows.Forms.Panel();
            this.HeaderBar.SuspendLayout();
            this.HeaderPanelTable.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderBar
            // 
            this.HeaderBar.Controls.Add(this.HeaderPanelTable);
            this.HeaderBar.Controls.Add(this.BtnMinimize);
            this.HeaderBar.Controls.Add(this.BtnMaximize);
            this.HeaderBar.Controls.Add(this.BtnClose);
            this.HeaderBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderBar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HeaderBar.Location = new System.Drawing.Point(0, 0);
            this.HeaderBar.Margin = new System.Windows.Forms.Padding(2);
            this.HeaderBar.Name = "HeaderBar";
            this.HeaderBar.Size = new System.Drawing.Size(590, 28);
            this.HeaderBar.TabIndex = 0;
            // 
            // HeaderPanelTable
            // 
            this.HeaderPanelTable.ColumnCount = 1;
            this.HeaderPanelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HeaderPanelTable.Controls.Add(this.MainMenu, 0, 0);
            this.HeaderPanelTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeaderPanelTable.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanelTable.Margin = new System.Windows.Forms.Padding(2);
            this.HeaderPanelTable.Name = "HeaderPanelTable";
            this.HeaderPanelTable.RowCount = 1;
            this.HeaderPanelTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HeaderPanelTable.Size = new System.Drawing.Size(458, 28);
            this.HeaderPanelTable.TabIndex = 3;
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.MainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HeaderTitle});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.MainMenu.Size = new System.Drawing.Size(458, 28);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            this.MainMenu.DoubleClick += new System.EventHandler(this.MainMenu_DoubleClick);
            this.MainMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainMenu_MouseDown);
            this.MainMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainMenu_MouseMove);
            this.MainMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainMenu_MouseUp);
            // 
            // HeaderTitle
            // 
            this.HeaderTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.HeaderTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderTitle.Name = "HeaderTitle";
            this.HeaderTitle.Size = new System.Drawing.Size(27, 21);
            this.HeaderTitle.Text = "%%";
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnMinimize.FlatAppearance.BorderSize = 0;
            this.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimize.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnMinimize.Location = new System.Drawing.Point(458, 0);
            this.BtnMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(44, 28);
            this.BtnMinimize.TabIndex = 2;
            this.BtnMinimize.Text = "-";
            this.BtnMinimize.UseVisualStyleBackColor = true;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // BtnMaximize
            // 
            this.BtnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnMaximize.FlatAppearance.BorderSize = 0;
            this.BtnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMaximize.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnMaximize.Location = new System.Drawing.Point(502, 0);
            this.BtnMaximize.Margin = new System.Windows.Forms.Padding(2);
            this.BtnMaximize.Name = "BtnMaximize";
            this.BtnMaximize.Size = new System.Drawing.Size(44, 28);
            this.BtnMaximize.TabIndex = 1;
            this.BtnMaximize.Text = "[ ]";
            this.BtnMaximize.UseVisualStyleBackColor = true;
            this.BtnMaximize.Click += new System.EventHandler(this.BtnMaximize_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnClose.Location = new System.Drawing.Point(546, 0);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(2);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(44, 28);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // Body
            // 
            this.Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Body.Location = new System.Drawing.Point(0, 28);
            this.Body.Margin = new System.Windows.Forms.Padding(2);
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(590, 364);
            this.Body.TabIndex = 1;
            // 
            // CustomUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.Body);
            this.Controls.Add(this.HeaderBar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomUI";
            this.Size = new System.Drawing.Size(590, 392);
            this.HeaderBar.ResumeLayout(false);
            this.HeaderPanelTable.ResumeLayout(false);
            this.HeaderPanelTable.PerformLayout();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel HeaderBar;
        public Panel Body;
        private Button BtnMinimize;
        private Button BtnMaximize;
        private Button BtnClose;
        private TableLayoutPanel HeaderPanelTable;
        public MenuStrip MainMenu;
        private ToolStripLabel HeaderTitle;
    }
}
