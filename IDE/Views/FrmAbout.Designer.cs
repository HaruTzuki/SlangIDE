namespace IDE.Views
{
    partial class FrmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbout));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnOK = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnLinkedInAlexandros = new System.Windows.Forms.PictureBox();
            this.BtnLinkedInDimitris = new System.Windows.Forms.PictureBox();
            this.LblWebSite = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.SlangIDELogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLinkedInAlexandros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLinkedInDimitris)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlangIDELogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Slang IDE for Slang Language.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(1, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 28);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnOK);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1, 214);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(482, 137);
            this.panel2.TabIndex = 3;
            // 
            // BtnOK
            // 
            this.BtnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(84)))), ((int)(((byte)(26)))));
            this.BtnOK.FlatAppearance.BorderSize = 0;
            this.BtnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOK.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOK.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnOK.Location = new System.Drawing.Point(397, 97);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(82, 33);
            this.BtnOK.TabIndex = 1;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = false;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnLinkedInAlexandros);
            this.panel3.Controls.Add(this.BtnLinkedInDimitris);
            this.panel3.Controls.Add(this.LblWebSite);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(239, 137);
            this.panel3.TabIndex = 0;
            // 
            // BtnLinkedInAlexandros
            // 
            this.BtnLinkedInAlexandros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLinkedInAlexandros.Image = global::IDE.Properties.Resources.linkedin;
            this.BtnLinkedInAlexandros.Location = new System.Drawing.Point(142, 68);
            this.BtnLinkedInAlexandros.Name = "BtnLinkedInAlexandros";
            this.BtnLinkedInAlexandros.Size = new System.Drawing.Size(32, 32);
            this.BtnLinkedInAlexandros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnLinkedInAlexandros.TabIndex = 3;
            this.BtnLinkedInAlexandros.TabStop = false;
            this.BtnLinkedInAlexandros.Click += new System.EventHandler(this.BtnLinkedInAlexandros_Click);
            // 
            // BtnLinkedInDimitris
            // 
            this.BtnLinkedInDimitris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLinkedInDimitris.Image = global::IDE.Properties.Resources.linkedin;
            this.BtnLinkedInDimitris.Location = new System.Drawing.Point(142, 25);
            this.BtnLinkedInDimitris.Name = "BtnLinkedInDimitris";
            this.BtnLinkedInDimitris.Size = new System.Drawing.Size(32, 32);
            this.BtnLinkedInDimitris.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnLinkedInDimitris.TabIndex = 2;
            this.BtnLinkedInDimitris.TabStop = false;
            this.BtnLinkedInDimitris.Click += new System.EventHandler(this.BtnLinkedInDimitris_Click);
            // 
            // LblWebSite
            // 
            this.LblWebSite.AutoSize = true;
            this.LblWebSite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblWebSite.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWebSite.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.LblWebSite.Location = new System.Drawing.Point(3, 117);
            this.LblWebSite.Name = "LblWebSite";
            this.LblWebSite.Size = new System.Drawing.Size(124, 13);
            this.LblWebSite.TabIndex = 1;
            this.LblWebSite.TabStop = true;
            this.LblWebSite.Text = "https://slang-lang.com";
            this.LblWebSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblWebSite_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 90);
            this.label2.TabIndex = 0;
            this.label2.Text = "Developers:\r\n\r\n- Vlachopoulos Dimitris\r\n\r\n\r\n- Matas Alexandros";
            // 
            // SlangIDELogo
            // 
            this.SlangIDELogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.SlangIDELogo.Location = new System.Drawing.Point(1, 1);
            this.SlangIDELogo.Name = "SlangIDELogo";
            this.SlangIDELogo.Size = new System.Drawing.Size(482, 185);
            this.SlangIDELogo.TabIndex = 0;
            this.SlangIDELogo.TabStop = false;
            // 
            // FrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BorderColour = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(484, 352);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SlangIDELogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAbout";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLinkedInAlexandros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLinkedInDimitris)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlangIDELogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox SlangIDELogo;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private LinkLabel LblWebSite;
        private Label label2;
        private Button BtnOK;
        private PictureBox BtnLinkedInDimitris;
        private PictureBox BtnLinkedInAlexandros;
    }
}