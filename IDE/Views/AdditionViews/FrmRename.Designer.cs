namespace IDE.Views.AdditionViews
{
    partial class FrmRename
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
            this.customUI1 = new IDE.Helper.Custom.CustomUI();
            this.BtnOK = new System.Windows.Forms.Button();
            this.TxtTo = new System.Windows.Forms.TextBox();
            this.TxtFrom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.customUI1.ContentsPanel.SuspendLayout();
            this.customUI1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // customUI1
            // 
            this.customUI1.AllowMaximize = false;
            this.customUI1.AllowMinimize = false;
            this.customUI1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            // 
            // customUI1.ContentsPanel
            // 
            this.customUI1.ContentsPanel.Controls.Add(this.BtnOK);
            this.customUI1.ContentsPanel.Controls.Add(this.TxtTo);
            this.customUI1.ContentsPanel.Controls.Add(this.TxtFrom);
            this.customUI1.ContentsPanel.Controls.Add(this.label2);
            this.customUI1.ContentsPanel.Controls.Add(this.label1);
            this.customUI1.ContentsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customUI1.ContentsPanel.Enabled = true;
            this.customUI1.ContentsPanel.Location = new System.Drawing.Point(0, 28);
            this.customUI1.ContentsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.customUI1.ContentsPanel.Name = "ContentsPanel";
            this.customUI1.ContentsPanel.Size = new System.Drawing.Size(386, 105);
            this.customUI1.ContentsPanel.TabIndex = 1;
            this.customUI1.ContentsPanel.Visible = true;
            this.customUI1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customUI1.FormClosingOperation = IDE.Helper.Custom.FormClosingOperations.CloseWindow;
            this.customUI1.Location = new System.Drawing.Point(1, 1);
            this.customUI1.Margin = new System.Windows.Forms.Padding(2);
            this.customUI1.Name = "customUI1";
            this.customUI1.Size = new System.Drawing.Size(386, 133);
            this.customUI1.TabIndex = 0;
            this.customUI1.Title = "%%";
            // 
            // BtnOK
            // 
            this.BtnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(84)))), ((int)(((byte)(26)))));
            this.BtnOK.FlatAppearance.BorderSize = 0;
            this.BtnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOK.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOK.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnOK.Location = new System.Drawing.Point(302, 59);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(81, 42);
            this.BtnOK.TabIndex = 4;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = false;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // TxtTo
            // 
            this.TxtTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.TxtTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TxtTo.Location = new System.Drawing.Point(236, 27);
            this.TxtTo.Name = "TxtTo";
            this.TxtTo.Size = new System.Drawing.Size(147, 23);
            this.TxtTo.TabIndex = 3;
            // 
            // TxtFrom
            // 
            this.TxtFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.TxtFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtFrom.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFrom.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TxtFrom.Location = new System.Drawing.Point(52, 27);
            this.TxtFrom.Name = "TxtFrom";
            this.TxtFrom.ReadOnly = true;
            this.TxtFrom.Size = new System.Drawing.Size(147, 23);
            this.TxtFrom.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(205, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(3, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "From:";
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // FrmRename
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 135);
            this.Controls.Add(this.customUI1);
            this.Name = "FrmRename";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRename";
            this.customUI1.ContentsPanel.ResumeLayout(false);
            this.customUI1.ContentsPanel.PerformLayout();
            this.customUI1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Helper.Custom.CustomUI customUI1;
        private Label label1;
        private Button BtnOK;
        private TextBox TxtTo;
        private TextBox TxtFrom;
        private Label label2;
        private ErrorProvider ErrorProvider;
    }
}