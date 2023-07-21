namespace IDE.Views.AdditionViews
{
    partial class FrmNewFileCreator
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
            this.CustomUI = new IDE.Helper.Custom.CustomUI();
            this.BtnOK = new System.Windows.Forms.Button();
            this.TxtFileName = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CustomUI.ContentsPanel.SuspendLayout();
            this.CustomUI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
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
            this.CustomUI.ContentsPanel.Controls.Add(this.TxtFileName);
            this.CustomUI.ContentsPanel.Controls.Add(this.LblName);
            this.CustomUI.ContentsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomUI.ContentsPanel.Enabled = true;
            this.CustomUI.ContentsPanel.Location = new System.Drawing.Point(0, 37);
            this.CustomUI.ContentsPanel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CustomUI.ContentsPanel.Name = "ContentsPanel";
            this.CustomUI.ContentsPanel.Size = new System.Drawing.Size(451, 114);
            this.CustomUI.ContentsPanel.TabIndex = 1;
            this.CustomUI.ContentsPanel.Visible = true;
            this.CustomUI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomUI.FormClosingOperation = IDE.Helper.Custom.FormClosingOperations.CloseWindow;
            this.CustomUI.Location = new System.Drawing.Point(1, 1);
            this.CustomUI.Margin = new System.Windows.Forms.Padding(4);
            this.CustomUI.Name = "CustomUI";
            this.CustomUI.Size = new System.Drawing.Size(451, 151);
            this.CustomUI.TabIndex = 0;
            this.CustomUI.Title = "Pick a name";
            // 
            // BtnOK
            // 
            this.BtnOK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(84)))), ((int)(((byte)(26)))));
            this.BtnOK.FlatAppearance.BorderSize = 0;
            this.BtnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOK.Location = new System.Drawing.Point(329, 53);
            this.BtnOK.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(117, 56);
            this.BtnOK.TabIndex = 2;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = false;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // TxtFileName
            // 
            this.TxtFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtFileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.TxtFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtFileName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TxtFileName.Location = new System.Drawing.Point(79, 18);
            this.TxtFileName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TxtFileName.Name = "TxtFileName";
            this.TxtFileName.Size = new System.Drawing.Size(367, 25);
            this.TxtFileName.TabIndex = 0;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(5, 22);
            this.LblName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(47, 17);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Name:";
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // FrmNewFileCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 153);
            this.Controls.Add(this.CustomUI);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmNewFileCreator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNewFileCreator";
            this.Load += new System.EventHandler(this.FrmNewFileCreator_Load);
            this.Shown += new System.EventHandler(this.FrmNewFileCreator_Shown);
            this.CustomUI.ContentsPanel.ResumeLayout(false);
            this.CustomUI.ContentsPanel.PerformLayout();
            this.CustomUI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Helper.Custom.CustomUI CustomUI;
        private Label LblName;
        private TextBox TxtFileName;
        private Button BtnOK;
        private ErrorProvider ErrorProvider;
    }
}