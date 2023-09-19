namespace Slang.IDE.Tools.GUIDGenerator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            RbtnX = new RadioButton();
            RbtnP = new RadioButton();
            RbtnB = new RadioButton();
            RbtnD = new RadioButton();
            RbtnN = new RadioButton();
            groupBox2 = new GroupBox();
            LblGuid = new Label();
            BtnCopy = new Button();
            BtnNewGuid = new Button();
            BtnExit = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(RbtnX);
            groupBox1.Controls.Add(RbtnP);
            groupBox1.Controls.Add(RbtnB);
            groupBox1.Controls.Add(RbtnD);
            groupBox1.Controls.Add(RbtnN);
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(509, 241);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "GUID Format";
            // 
            // RbtnX
            // 
            RbtnX.AutoSize = true;
            RbtnX.Location = new Point(7, 177);
            RbtnX.Margin = new Padding(3, 4, 3, 4);
            RbtnX.Name = "RbtnX";
            RbtnX.Size = new Size(501, 24);
            RbtnX.TabIndex = 4;
            RbtnX.Text = "{0x00000000,0x0000,0x0000,{0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00}}";
            RbtnX.UseVisualStyleBackColor = true;
            RbtnX.CheckedChanged += RadioButtons_CheckedChanged;
            // 
            // RbtnP
            // 
            RbtnP.AutoSize = true;
            RbtnP.Location = new Point(7, 144);
            RbtnP.Margin = new Padding(3, 4, 3, 4);
            RbtnP.Name = "RbtnP";
            RbtnP.Size = new Size(288, 24);
            RbtnP.TabIndex = 3;
            RbtnP.Text = "(xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx)";
            RbtnP.UseVisualStyleBackColor = true;
            RbtnP.CheckedChanged += RadioButtons_CheckedChanged;
            // 
            // RbtnB
            // 
            RbtnB.AutoSize = true;
            RbtnB.Location = new Point(7, 111);
            RbtnB.Margin = new Padding(3, 4, 3, 4);
            RbtnB.Name = "RbtnB";
            RbtnB.Size = new Size(288, 24);
            RbtnB.TabIndex = 2;
            RbtnB.Text = "{xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx}";
            RbtnB.UseVisualStyleBackColor = true;
            RbtnB.CheckedChanged += RadioButtons_CheckedChanged;
            // 
            // RbtnD
            // 
            RbtnD.AutoSize = true;
            RbtnD.Checked = true;
            RbtnD.Location = new Point(7, 77);
            RbtnD.Margin = new Padding(3, 4, 3, 4);
            RbtnD.Name = "RbtnD";
            RbtnD.Size = new Size(278, 24);
            RbtnD.TabIndex = 1;
            RbtnD.TabStop = true;
            RbtnD.Text = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx";
            RbtnD.UseVisualStyleBackColor = true;
            RbtnD.CheckedChanged += RadioButtons_CheckedChanged;
            // 
            // RbtnN
            // 
            RbtnN.AutoSize = true;
            RbtnN.Location = new Point(7, 44);
            RbtnN.Margin = new Padding(3, 4, 3, 4);
            RbtnN.Name = "RbtnN";
            RbtnN.Size = new Size(254, 24);
            RbtnN.TabIndex = 0;
            RbtnN.Text = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
            RbtnN.UseVisualStyleBackColor = true;
            RbtnN.CheckedChanged += RadioButtons_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(LblGuid);
            groupBox2.Location = new Point(14, 265);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(509, 143);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Result";
            // 
            // LblGuid
            // 
            LblGuid.Dock = DockStyle.Fill;
            LblGuid.Location = new Point(3, 24);
            LblGuid.Name = "LblGuid";
            LblGuid.Size = new Size(503, 115);
            LblGuid.TabIndex = 0;
            LblGuid.Text = "label1";
            LblGuid.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BtnCopy
            // 
            BtnCopy.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnCopy.Location = new Point(437, 416);
            BtnCopy.Margin = new Padding(3, 4, 3, 4);
            BtnCopy.Name = "BtnCopy";
            BtnCopy.Size = new Size(86, 51);
            BtnCopy.TabIndex = 2;
            BtnCopy.Text = "Copy";
            BtnCopy.UseVisualStyleBackColor = true;
            BtnCopy.Click += BtnCopy_Click;
            // 
            // BtnNewGuid
            // 
            BtnNewGuid.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnNewGuid.Location = new Point(344, 416);
            BtnNewGuid.Margin = new Padding(3, 4, 3, 4);
            BtnNewGuid.Name = "BtnNewGuid";
            BtnNewGuid.Size = new Size(86, 51);
            BtnNewGuid.TabIndex = 3;
            BtnNewGuid.Text = "New GUID";
            BtnNewGuid.UseVisualStyleBackColor = true;
            BtnNewGuid.Click += BtnNewGuid_Click;
            // 
            // BtnExit
            // 
            BtnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnExit.Location = new Point(437, 475);
            BtnExit.Margin = new Padding(3, 4, 3, 4);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(86, 51);
            BtnExit.TabIndex = 4;
            BtnExit.Text = "Exit";
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += BtnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(536, 532);
            Controls.Add(BtnExit);
            Controls.Add(BtnNewGuid);
            Controls.Add(BtnCopy);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create GUID";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }



        #endregion

        private GroupBox groupBox1;
        private RadioButton RbtnB;
        private RadioButton RbtnD;
        private RadioButton RbtnN;
        private GroupBox groupBox2;
        private Label LblGuid;
        private Button BtnCopy;
        private Button BtnNewGuid;
        private Button BtnExit;
        private RadioButton RbtnX;
        private RadioButton RbtnP;
    }
}