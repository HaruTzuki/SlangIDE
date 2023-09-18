namespace IDE.Views.Options
{
    partial class UcLanguageSlangOptions
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtMiddlewarePath = new System.Windows.Forms.TextBox();
            this.TxtCliPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Middleware";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Slang CLI";
            // 
            // TxtMiddlewarePath
            // 
            this.TxtMiddlewarePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.TxtMiddlewarePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtMiddlewarePath.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TxtMiddlewarePath.Location = new System.Drawing.Point(24, 30);
            this.TxtMiddlewarePath.Name = "TxtMiddlewarePath";
            this.TxtMiddlewarePath.Size = new System.Drawing.Size(408, 22);
            this.TxtMiddlewarePath.TabIndex = 2;
            // 
            // TxtCliPath
            // 
            this.TxtCliPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.TxtCliPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCliPath.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TxtCliPath.Location = new System.Drawing.Point(24, 82);
            this.TxtCliPath.Name = "TxtCliPath";
            this.TxtCliPath.Size = new System.Drawing.Size(408, 22);
            this.TxtCliPath.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(21, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(364, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Note: If you change these values maybe you cause unexpected issues.";
            // 
            // UcLanguageSlangOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtCliPath);
            this.Controls.Add(this.TxtMiddlewarePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Name = "UcLanguageSlangOptions";
            this.Size = new System.Drawing.Size(455, 310);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TxtMiddlewarePath;
        private TextBox TxtCliPath;
        private Label label3;
    }
}
