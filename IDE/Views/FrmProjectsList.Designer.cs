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
            this.TemplatesListView.Location = new System.Drawing.Point(8, 6);
            this.TemplatesListView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TemplatesListView.Name = "TemplatesListView";
            this.TemplatesListView.Size = new System.Drawing.Size(229, 465);
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
            this.BtnOK.Location = new System.Drawing.Point(667, 105);
            this.BtnOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(93, 38);
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
            this.LblProjectName.Location = new System.Drawing.Point(241, 6);
            this.LblProjectName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.TxtProjectName.Location = new System.Drawing.Point(244, 24);
            this.TxtProjectName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtProjectName.Name = "TxtProjectName";
            this.TxtProjectName.Size = new System.Drawing.Size(516, 25);
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
            this.TxtFilePath.Location = new System.Drawing.Point(244, 67);
            this.TxtFilePath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtFilePath.Name = "TxtFilePath";
            this.TxtFilePath.Size = new System.Drawing.Size(483, 25);
            this.TxtFilePath.TabIndex = 5;
            this.TxtFilePath.Text = "New Project";
            // 
            // LblPath
            // 
            this.LblPath.AutoSize = true;
            this.LblPath.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.LblPath.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LblPath.Location = new System.Drawing.Point(241, 50);
            this.LblPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.BtnProjectPath.Location = new System.Drawing.Point(730, 71);
            this.BtnProjectPath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnProjectPath.Name = "BtnProjectPath";
            this.BtnProjectPath.Size = new System.Drawing.Size(29, 20);
            this.BtnProjectPath.TabIndex = 6;
            this.BtnProjectPath.Text = "...";
            this.BtnProjectPath.UseVisualStyleBackColor = false;
            // 
            // FrmProjectsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(767, 478);
            this.Controls.Add(this.TemplatesListView);
            this.Controls.Add(this.LblProjectName);
            this.Controls.Add(this.TxtProjectName);
            this.Controls.Add(this.LblPath);
            this.Controls.Add(this.TxtFilePath);
            this.Controls.Add(this.BtnProjectPath);
            this.Controls.Add(this.BtnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProjectsList";
            this.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Template Selection";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmProjectsList_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}