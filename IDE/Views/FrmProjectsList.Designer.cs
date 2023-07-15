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
            components = new System.ComponentModel.Container();
            ListViewItem listViewItem1 = new ListViewItem("Empty Project", "file-regular.png");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProjectsList));
            listView1 = new ListView();
            imageList1 = new ImageList(components);
            BtnOK = new Button();
            label1 = new Label();
            TxtProjectName = new TextBox();
            TxtFilePath = new TextBox();
            label2 = new Label();
            BtnProjectPath = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.BackColor = Color.FromArgb(61, 61, 61);
            listView1.BorderStyle = BorderStyle.FixedSingle;
            listView1.ForeColor = Color.WhiteSmoke;
            listViewItem1.Tag = "{92138572-796A-496F-A104-BBF2B29C5148}";
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listView1.LargeImageList = imageList1;
            listView1.Location = new Point(16, 34);
            listView1.Margin = new Padding(3, 2, 3, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(171, 313);
            listView1.SmallImageList = imageList1;
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "file-regular.png");
            // 
            // BtnOK
            // 
            BtnOK.BackColor = Color.FromArgb(172, 84, 26);
            BtnOK.FlatAppearance.BorderSize = 0;
            BtnOK.FlatStyle = FlatStyle.Flat;
            BtnOK.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnOK.ForeColor = Color.WhiteSmoke;
            BtnOK.Location = new Point(591, 120);
            BtnOK.Margin = new Padding(3, 2, 3, 2);
            BtnOK.Name = "BtnOK";
            BtnOK.Size = new Size(109, 23);
            BtnOK.TabIndex = 1;
            BtnOK.Text = "Create";
            BtnOK.UseVisualStyleBackColor = false;
            BtnOK.Click += BtnOK_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(193, 34);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 2;
            label1.Text = "Project Name:";
            // 
            // TxtProjectName
            // 
            TxtProjectName.BackColor = Color.FromArgb(61, 61, 61);
            TxtProjectName.BorderStyle = BorderStyle.FixedSingle;
            TxtProjectName.ForeColor = Color.WhiteSmoke;
            TxtProjectName.Location = new Point(193, 51);
            TxtProjectName.Margin = new Padding(3, 2, 3, 2);
            TxtProjectName.Name = "TxtProjectName";
            TxtProjectName.Size = new Size(507, 23);
            TxtProjectName.TabIndex = 3;
            TxtProjectName.Text = "New Project";
            // 
            // TxtFilePath
            // 
            TxtFilePath.BackColor = Color.FromArgb(61, 61, 61);
            TxtFilePath.BorderStyle = BorderStyle.FixedSingle;
            TxtFilePath.ForeColor = Color.WhiteSmoke;
            TxtFilePath.Location = new Point(193, 93);
            TxtFilePath.Margin = new Padding(3, 2, 3, 2);
            TxtFilePath.Name = "TxtFilePath";
            TxtFilePath.Size = new Size(474, 23);
            TxtFilePath.TabIndex = 5;
            TxtFilePath.Text = "New Project";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(193, 76);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 4;
            label2.Text = "Path:";
            // 
            // BtnProjectPath
            // 
            BtnProjectPath.BackColor = Color.FromArgb(172, 84, 26);
            BtnProjectPath.FlatAppearance.BorderSize = 0;
            BtnProjectPath.FlatStyle = FlatStyle.Flat;
            BtnProjectPath.ForeColor = Color.WhiteSmoke;
            BtnProjectPath.Location = new Point(672, 93);
            BtnProjectPath.Margin = new Padding(3, 2, 3, 2);
            BtnProjectPath.Name = "BtnProjectPath";
            BtnProjectPath.Size = new Size(28, 22);
            BtnProjectPath.TabIndex = 6;
            BtnProjectPath.Text = "...";
            BtnProjectPath.UseVisualStyleBackColor = false;
            // 
            // FrmProjectsList
            // 
            AllowResizing = false;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderColour = Color.MediumSlateBlue;
            ClientSize = new Size(704, 359);
            Controls.Add(BtnProjectPath);
            Controls.Add(TxtFilePath);
            Controls.Add(label2);
            Controls.Add(TxtProjectName);
            Controls.Add(label1);
            Controls.Add(BtnOK);
            Controls.Add(listView1);
            FormClosingOperations = Helper.Custom.FormClosingOperations.CloseApplication;
            FormTitle = "Template Selection";
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmProjectsList";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmProjectsList";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Button BtnOK;
        private ImageList imageList1;
        private Label label1;
        private TextBox TxtProjectName;
        private TextBox TxtFilePath;
        private Label label2;
        private Button BtnProjectPath;
    }
}