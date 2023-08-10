namespace IDE.Views.Options
{
    partial class UcTextEditorOptions
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
            this.LblFont = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IsBold = new System.Windows.Forms.CheckBox();
            this.IsItalic = new System.Windows.Forms.CheckBox();
            this.BtnResetDefault = new System.Windows.Forms.Button();
            this.CbxSizes = new IDE.Controls.FlatCombo();
            this.CbxFonts = new IDE.Controls.FlatCombo();
            this.SuspendLayout();
            // 
            // LblFont
            // 
            this.LblFont.AutoSize = true;
            this.LblFont.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.LblFont.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LblFont.Location = new System.Drawing.Point(17, 31);
            this.LblFont.Name = "LblFont";
            this.LblFont.Size = new System.Drawing.Size(34, 15);
            this.LblFont.TabIndex = 0;
            this.LblFont.Text = "Font:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(206, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Size:";
            // 
            // IsBold
            // 
            this.IsBold.AutoSize = true;
            this.IsBold.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.IsBold.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.IsBold.Location = new System.Drawing.Point(305, 49);
            this.IsBold.Name = "IsBold";
            this.IsBold.Size = new System.Drawing.Size(54, 21);
            this.IsBold.TabIndex = 4;
            this.IsBold.Text = "Bold";
            this.IsBold.UseVisualStyleBackColor = true;
            // 
            // IsItalic
            // 
            this.IsItalic.AutoSize = true;
            this.IsItalic.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.IsItalic.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.IsItalic.Location = new System.Drawing.Point(365, 49);
            this.IsItalic.Name = "IsItalic";
            this.IsItalic.Size = new System.Drawing.Size(55, 21);
            this.IsItalic.TabIndex = 5;
            this.IsItalic.Text = "Italic";
            this.IsItalic.UseVisualStyleBackColor = true;
            // 
            // BtnResetDefault
            // 
            this.BtnResetDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnResetDefault.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(84)))), ((int)(((byte)(26)))));
            this.BtnResetDefault.FlatAppearance.BorderSize = 0;
            this.BtnResetDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnResetDefault.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.BtnResetDefault.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnResetDefault.Location = new System.Drawing.Point(316, 257);
            this.BtnResetDefault.Name = "BtnResetDefault";
            this.BtnResetDefault.Size = new System.Drawing.Size(115, 48);
            this.BtnResetDefault.TabIndex = 6;
            this.BtnResetDefault.Text = "Reset Default Values";
            this.BtnResetDefault.UseVisualStyleBackColor = false;
            this.BtnResetDefault.Click += new System.EventHandler(this.BtnResetDefault_Click);
            // 
            // CbxSizes
            // 
            this.CbxSizes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.CbxSizes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CbxSizes.ButtonColor = System.Drawing.Color.DimGray;
            this.CbxSizes.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.CbxSizes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CbxSizes.FormattingEnabled = true;
            this.CbxSizes.Location = new System.Drawing.Point(209, 49);
            this.CbxSizes.Name = "CbxSizes";
            this.CbxSizes.Size = new System.Drawing.Size(90, 23);
            this.CbxSizes.TabIndex = 3;
            // 
            // CbxFonts
            // 
            this.CbxFonts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.CbxFonts.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CbxFonts.ButtonColor = System.Drawing.Color.DimGray;
            this.CbxFonts.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.CbxFonts.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CbxFonts.FormattingEnabled = true;
            this.CbxFonts.Location = new System.Drawing.Point(20, 49);
            this.CbxFonts.Name = "CbxFonts";
            this.CbxFonts.Size = new System.Drawing.Size(183, 23);
            this.CbxFonts.TabIndex = 1;
            // 
            // UcTextEditorOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.BtnResetDefault);
            this.Controls.Add(this.IsItalic);
            this.Controls.Add(this.IsBold);
            this.Controls.Add(this.CbxSizes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbxFonts);
            this.Controls.Add(this.LblFont);
            this.Name = "UcTextEditorOptions";
            this.Size = new System.Drawing.Size(448, 326);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblFont;
        private Controls.FlatCombo CbxFonts;
        private Controls.FlatCombo CbxSizes;
        private Label label1;
        private CheckBox IsBold;
        private CheckBox IsItalic;
        private Button BtnResetDefault;
    }
}
