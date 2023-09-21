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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Empty Project", "file-regular.png");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProjectsList));
            this.TemplatesListView = new System.Windows.Forms.ListView();
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
            this.TemplatesListView.Location = new System.Drawing.Point(8, 6);
            this.TemplatesListView.Margin = new System.Windows.Forms.Padding(2);
            this.TemplatesListView.MultiSelect = false;
            this.TemplatesListView.Name = "TemplatesListView";
            this.TemplatesListView.Size = new System.Drawing.Size(156, 232);
            this.TemplatesListView.TabIndex = 0;
            this.TemplatesListView.UseCompatibleStateImageBehavior = false;
            this.TemplatesListView.View = System.Windows.Forms.View.List;
            // 
            // BtnOK
            // 
            this.BtnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(84)))), ((int)(((byte)(26)))));
            this.BtnOK.FlatAppearance.BorderSize = 0;
            this.BtnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOK.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.BtnOK.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnOK.Location = new System.Drawing.Point(447, 96);
            this.BtnOK.Margin = new System.Windows.Forms.Padding(2);
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
            this.LblProjectName.Location = new System.Drawing.Point(168, 6);
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
            this.TxtProjectName.Location = new System.Drawing.Point(171, 24);
            this.TxtProjectName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtProjectName.Name = "TxtProjectName";
            this.TxtProjectName.Size = new System.Drawing.Size(369, 25);
            this.TxtProjectName.TabIndex = 3;
            this.TxtProjectName.Text = "NewProject";
            // 
            // TxtFilePath
            // 
            this.TxtFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtFilePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.TxtFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtFilePath.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.TxtFilePath.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TxtFilePath.Location = new System.Drawing.Point(171, 67);
            this.TxtFilePath.Margin = new System.Windows.Forms.Padding(2);
            this.TxtFilePath.Name = "TxtFilePath";
            this.TxtFilePath.Size = new System.Drawing.Size(336, 25);
            this.TxtFilePath.TabIndex = 5;
            this.TxtFilePath.Text = "C:\\";
            // 
            // LblPath
            // 
            this.LblPath.AutoSize = true;
            this.LblPath.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.LblPath.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LblPath.Location = new System.Drawing.Point(168, 50);
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
            this.BtnProjectPath.Location = new System.Drawing.Point(511, 67);
            this.BtnProjectPath.Margin = new System.Windows.Forms.Padding(2);
            this.BtnProjectPath.Name = "BtnProjectPath";
            this.BtnProjectPath.Size = new System.Drawing.Size(29, 25);
            this.BtnProjectPath.TabIndex = 6;
            this.BtnProjectPath.Text = "...";
            this.BtnProjectPath.UseVisualStyleBackColor = false;
            // 
            // FrmProjectsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(547, 245);
            this.Controls.Add(this.TemplatesListView);
            this.Controls.Add(this.LblProjectName);
            this.Controls.Add(this.TxtProjectName);
            this.Controls.Add(this.LblPath);
            this.Controls.Add(this.TxtFilePath);
            this.Controls.Add(this.BtnProjectPath);
            this.Controls.Add(this.BtnOK);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProjectsList";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Template Selection";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmProjectsList_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView TemplatesListView;
        private Button BtnOK;
        private Label LblProjectName;
        private TextBox TxtProjectName;
        private TextBox TxtFilePath;
        private Label LblPath;
        private Button BtnProjectPath;
    }
}