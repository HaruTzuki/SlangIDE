namespace IDE.Controls
{
    partial class UcTextEditor
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
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.lineNumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtb
            // 
            this.rtb.AcceptsTab = true;
            this.rtb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.rtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold);
            this.rtb.ForeColor = System.Drawing.Color.White;
            this.rtb.Location = new System.Drawing.Point(50, 0);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(250, 150);
            this.rtb.TabIndex = 0;
            this.rtb.Text = "";
            this.rtb.TextChanged += new System.EventHandler(this.rtb_TextChanged);
            // 
            // lineNumberLabel
            // 
            this.lineNumberLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lineNumberLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.lineNumberLabel.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold);
            this.lineNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lineNumberLabel.Location = new System.Drawing.Point(0, 0);
            this.lineNumberLabel.Name = "lineNumberLabel";
            this.lineNumberLabel.Size = new System.Drawing.Size(50, 150);
            this.lineNumberLabel.TabIndex = 1;
            this.lineNumberLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // UcTextEditor
            // 
            this.Controls.Add(this.rtb);
            this.Controls.Add(this.lineNumberLabel);
            this.Name = "UcTextEditor";
            this.Size = new System.Drawing.Size(300, 150);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox rtb;
        private Label lineNumberLabel;
    }
}
