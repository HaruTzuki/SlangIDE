namespace IDE.Views
{
    partial class FrmProjectsList
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Empty Project", "file-regular.png");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProjectsList));
            this.TemplatesListView = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BtnOK = new System.Windows.Forms.Button();
            this.LblProjectName = new System.Windows.Forms.Label();
            this.TxtProjectName = new System.Windows.Forms.TextBox();
            this.TxtFilePath = new System.Windows.Forms.TextBox();
            this.LblPath = new System.Windows.Forms.Label();
            this.BtnProjectPath = new System.Windows.Forms.Button();
            this.CustomUI = new IDE.Helper.Custom.CustomUI();
            this.CustomUI.ContentsPanel.SuspendLayout();
            this.CustomUI.SuspendLayout();
            this.SuspendLayout();
            // 
            // TemplatesListView
            // 
            this.TemplatesListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TemplatesListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.TemplatesListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TemplatesListView.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TemplatesListView.HideSelection = false;
            listViewItem1.Tag = "{92138572-796A-496F-A104-BBF2B29C5148}";
            this.TemplatesListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.TemplatesListView.LargeImageList = this.imageList1;
            this.TemplatesListView.Location = new System.Drawing.Point(9, 10);
            this.TemplatesListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TemplatesListView.Name = "TemplatesListView";
            this.TemplatesListView.Size = new System.Drawing.Size(305, 417);
            this.TemplatesListView.SmallImageList = this.imageList1;
            this.TemplatesListView.TabIndex = 0;
            this.TemplatesListView.UseCompatibleStateImageBehavior = false;
            this.TemplatesListView.View = System.Windows.Forms.View.List;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "file-regular.png");
            // 
            // BtnOK
            // 
            this.BtnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(84)))), ((int)(((byte)(26)))));
            this.BtnOK.FlatAppearance.BorderSize = 0;
            this.BtnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOK.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.BtnOK.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnOK.Location = new System.Drawing.Point(654, 126);
            this.BtnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(93, 33);
            this.BtnOK.TabIndex = 1;
            this.BtnOK.Text = "Create";
            this.BtnOK.UseVisualStyleBackColor = false;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // LblProjectName
            // 
            this.LblProjectName.AutoSize = true;
            this.LblProjectName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.LblProjectName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LblProjectName.Location = new System.Drawing.Point(320, 26);
            this.LblProjectName.Name = "LblProjectName";
            this.LblProjectName.Size = new System.Drawing.Size(82, 15);
            this.LblProjectName.TabIndex = 2;
            this.LblProjectName.Text = "Project Name:";
            // 
            // TxtProjectName
            // 
            this.TxtProjectName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtProjectName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.TxtProjectName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtProjectName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.TxtProjectName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TxtProjectName.Location = new System.Drawing.Point(320, 49);
            this.TxtProjectName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtProjectName.Name = "TxtProjectName";
            this.TxtProjectName.Size = new System.Drawing.Size(427, 25);
            this.TxtProjectName.TabIndex = 3;
            this.TxtProjectName.Text = "New Project";
            // 
            // TxtFilePath
            // 
            this.TxtFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtFilePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.TxtFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtFilePath.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.TxtFilePath.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TxtFilePath.Location = new System.Drawing.Point(320, 97);
            this.TxtFilePath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtFilePath.Name = "TxtFilePath";
            this.TxtFilePath.Size = new System.Drawing.Size(382, 25);
            this.TxtFilePath.TabIndex = 5;
            this.TxtFilePath.Text = "New Project";
            // 
            // LblPath
            // 
            this.LblPath.AutoSize = true;
            this.LblPath.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.LblPath.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LblPath.Location = new System.Drawing.Point(320, 78);
            this.LblPath.Name = "LblPath";
            this.LblPath.Size = new System.Drawing.Size(34, 15);
            this.LblPath.TabIndex = 4;
            this.LblPath.Text = "Path:";
            // 
            // BtnProjectPath
            // 
            this.BtnProjectPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnProjectPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(84)))), ((int)(((byte)(26)))));
            this.BtnProjectPath.FlatAppearance.BorderSize = 0;
            this.BtnProjectPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProjectPath.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.BtnProjectPath.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnProjectPath.Location = new System.Drawing.Point(708, 95);
            this.BtnProjectPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnProjectPath.Name = "BtnProjectPath";
            this.BtnProjectPath.Size = new System.Drawing.Size(39, 25);
            this.BtnProjectPath.TabIndex = 6;
            this.BtnProjectPath.Text = "...";
            this.BtnProjectPath.UseVisualStyleBackColor = false;
            // 
            // CustomUI
            // 
            this.CustomUI.AllowMaximize = false;
            this.CustomUI.AllowMinimize = false;
            this.CustomUI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            // 
            // CustomUI.ContentsPanel
            // 
            this.CustomUI.ContentsPanel.Controls.Add(this.BtnOK);
            this.CustomUI.ContentsPanel.Controls.Add(this.BtnProjectPath);
            this.CustomUI.ContentsPanel.Controls.Add(this.TxtFilePath);
            this.CustomUI.ContentsPanel.Controls.Add(this.LblPath);
            this.CustomUI.ContentsPanel.Controls.Add(this.TxtProjectName);
            this.CustomUI.ContentsPanel.Controls.Add(this.LblProjectName);
            this.CustomUI.ContentsPanel.Controls.Add(this.TemplatesListView);
            this.CustomUI.ContentsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomUI.ContentsPanel.Enabled = true;
            this.CustomUI.ContentsPanel.Location = new System.Drawing.Point(0, 28);
            this.CustomUI.ContentsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.CustomUI.ContentsPanel.Name = "ContentsPanel";
            this.CustomUI.ContentsPanel.Size = new System.Drawing.Size(757, 440);
            this.CustomUI.ContentsPanel.TabIndex = 1;
            this.CustomUI.ContentsPanel.Visible = true;
            this.CustomUI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomUI.FormClosingOperation = IDE.Helper.Custom.FormClosingOperations.CloseApplication;
            this.CustomUI.Location = new System.Drawing.Point(5, 5);
            this.CustomUI.Margin = new System.Windows.Forms.Padding(2);
            this.CustomUI.Name = "CustomUI";
            this.CustomUI.Size = new System.Drawing.Size(757, 468);
            this.CustomUI.TabIndex = 7;
            this.CustomUI.Title = "Template Selection";
            // 
            // FrmProjectsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColour = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(767, 478);
            this.Controls.Add(this.CustomUI);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmProjectsList";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmProjectsList";
            this.CustomUI.ContentsPanel.ResumeLayout(false);
            this.CustomUI.ContentsPanel.PerformLayout();
            this.CustomUI.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView TemplatesListView;
        private Button BtnOK;
        private ImageList imageList1;
        private Label LblProjectName;
        private TextBox TxtProjectName;
        private TextBox TxtFilePath;
        private Label LblPath;
        private Button BtnProjectPath;
        private Helper.Custom.CustomUI CustomUI;
    }
}