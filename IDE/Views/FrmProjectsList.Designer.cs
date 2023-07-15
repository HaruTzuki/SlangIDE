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
            TemplatesListView = new ListView();
            imageList1 = new ImageList(components);
            BtnOK = new Button();
            LblProjectName = new Label();
            TxtProjectName = new TextBox();
            TxtFilePath = new TextBox();
            LblPath = new Label();
            BtnProjectPath = new Button();
            SuspendLayout();
            // 
            // TemplatesListView
            // 
            TemplatesListView.BackColor = Color.FromArgb(61, 61, 61);
            TemplatesListView.BorderStyle = BorderStyle.FixedSingle;
            TemplatesListView.ForeColor = Color.WhiteSmoke;
            listViewItem1.Tag = "{92138572-796A-496F-A104-BBF2B29C5148}";
            TemplatesListView.Items.AddRange(new ListViewItem[] { listViewItem1 });
            TemplatesListView.LargeImageList = imageList1;
            TemplatesListView.Location = new Point(12, 3);
            TemplatesListView.Margin = new Padding(3, 2, 3, 2);
            TemplatesListView.Name = "TemplatesListView";
            TemplatesListView.Size = new Size(171, 313);
            TemplatesListView.SmallImageList = imageList1;
            TemplatesListView.TabIndex = 0;
            TemplatesListView.UseCompatibleStateImageBehavior = false;
            TemplatesListView.View = View.List;
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
            BtnOK.Location = new Point(587, 88);
            BtnOK.Margin = new Padding(3, 2, 3, 2);
            BtnOK.Name = "BtnOK";
            BtnOK.Size = new Size(109, 23);
            BtnOK.TabIndex = 1;
            BtnOK.Text = "Create";
            BtnOK.UseVisualStyleBackColor = false;
            BtnOK.Click += BtnOK_Click;
            // 
            // LblProjectName
            // 
            LblProjectName.AutoSize = true;
            LblProjectName.ForeColor = Color.WhiteSmoke;
            LblProjectName.Location = new Point(189, 2);
            LblProjectName.Name = "LblProjectName";
            LblProjectName.Size = new Size(82, 15);
            LblProjectName.TabIndex = 2;
            LblProjectName.Text = "Project Name:";
            // 
            // TxtProjectName
            // 
            TxtProjectName.BackColor = Color.FromArgb(61, 61, 61);
            TxtProjectName.BorderStyle = BorderStyle.FixedSingle;
            TxtProjectName.ForeColor = Color.WhiteSmoke;
            TxtProjectName.Location = new Point(189, 19);
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
            TxtFilePath.Location = new Point(189, 61);
            TxtFilePath.Margin = new Padding(3, 2, 3, 2);
            TxtFilePath.Name = "TxtFilePath";
            TxtFilePath.Size = new Size(474, 23);
            TxtFilePath.TabIndex = 5;
            TxtFilePath.Text = "New Project";
            // 
            // LblPath
            // 
            LblPath.AutoSize = true;
            LblPath.ForeColor = Color.WhiteSmoke;
            LblPath.Location = new Point(189, 44);
            LblPath.Name = "LblPath";
            LblPath.Size = new Size(34, 15);
            LblPath.TabIndex = 4;
            LblPath.Text = "Path:";
            // 
            // BtnProjectPath
            // 
            BtnProjectPath.BackColor = Color.FromArgb(172, 84, 26);
            BtnProjectPath.FlatAppearance.BorderSize = 0;
            BtnProjectPath.FlatStyle = FlatStyle.Flat;
            BtnProjectPath.ForeColor = Color.WhiteSmoke;
            BtnProjectPath.Location = new Point(668, 61);
            BtnProjectPath.Margin = new Padding(3, 2, 3, 2);
            BtnProjectPath.Name = "BtnProjectPath";
            BtnProjectPath.Size = new Size(28, 22);
            BtnProjectPath.TabIndex = 6;
            BtnProjectPath.Text = "...";
            BtnProjectPath.UseVisualStyleBackColor = false;
            // 
            // FrmProjectsList
            // 
            AllowMaximize = true;
            AllowMinimize = true;
            AllowResizing = false;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderColour = Color.MediumSlateBlue;
            ClientSize = new Size(704, 359);
            FormClosingOperations = Helper.Custom.FormClosingOperations.CloseApplication;
            FormTitle = "Template Selection";
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmProjectsList";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmProjectsList";
            ResumeLayout(false);
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