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
            ListViewItem listViewItem2 = new ListViewItem("Empty Project", "file-regular.png");
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
            listViewItem2.Tag = "{92138572-796A-496F-A104-BBF2B29C5148}";
            listView1.Items.AddRange(new ListViewItem[] { listViewItem2 });
            listView1.LargeImageList = imageList1;
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(195, 453);
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
            BtnOK.Location = new Point(667, 132);
            BtnOK.Name = "BtnOK";
            BtnOK.Size = new Size(125, 34);
            BtnOK.TabIndex = 1;
            BtnOK.Text = "Create";
            BtnOK.UseVisualStyleBackColor = true;
            BtnOK.Click += BtnOK_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(213, 12);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 2;
            label1.Text = "Project Name:";
            // 
            // TxtProjectName
            // 
            TxtProjectName.Location = new Point(213, 35);
            TxtProjectName.Name = "TxtProjectName";
            TxtProjectName.Size = new Size(579, 27);
            TxtProjectName.TabIndex = 3;
            TxtProjectName.Text = "New Project";
            // 
            // TxtFilePath
            // 
            TxtFilePath.Location = new Point(213, 88);
            TxtFilePath.Name = "TxtFilePath";
            TxtFilePath.Size = new Size(541, 27);
            TxtFilePath.TabIndex = 5;
            TxtFilePath.Text = "New Project";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(213, 65);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 4;
            label2.Text = "Path:";
            // 
            // BtnProjectPath
            // 
            BtnProjectPath.Location = new Point(760, 86);
            BtnProjectPath.Name = "BtnProjectPath";
            BtnProjectPath.Size = new Size(32, 29);
            BtnProjectPath.TabIndex = 6;
            BtnProjectPath.Text = "...";
            BtnProjectPath.UseVisualStyleBackColor = true;
            // 
            // FrmProjectsList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 479);
            Controls.Add(BtnProjectPath);
            Controls.Add(TxtFilePath);
            Controls.Add(label2);
            Controls.Add(TxtProjectName);
            Controls.Add(label1);
            Controls.Add(BtnOK);
            Controls.Add(listView1);
            Name = "FrmProjectsList";
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