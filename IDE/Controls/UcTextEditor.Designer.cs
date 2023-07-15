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
            rtb = new RichTextBox();
            lineNumberLabel = new Label();
            SuspendLayout();
            // 
            // rtb
            // 
            rtb.BackColor = Color.FromArgb(30, 30, 30);
            rtb.BorderStyle = BorderStyle.None;
            rtb.Dock = DockStyle.Fill;
            rtb.Font = new Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            rtb.ForeColor = Color.White;
            rtb.Location = new Point(50, 0);
            rtb.Name = "rtb";
            rtb.Size = new Size(250, 150);
            rtb.TabIndex = 0;
            rtb.Text = "";
            rtb.VScroll += rtb_VScroll;
            rtb.FontChanged += rtb_FontChanged;
            rtb.TextChanged += rtb_TextChanged;
            // 
            // lineNumberLabel
            // 
            lineNumberLabel.BackColor = Color.FromArgb(30, 30, 30);
            lineNumberLabel.Dock = DockStyle.Left;
            lineNumberLabel.Font = new Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lineNumberLabel.ForeColor = Color.FromArgb(138, 138, 138);
            lineNumberLabel.Location = new Point(0, 0);
            lineNumberLabel.Name = "lineNumberLabel";
            lineNumberLabel.Size = new Size(50, 150);
            lineNumberLabel.TabIndex = 1;
            lineNumberLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // UcTextEditor
            // 
            Controls.Add(rtb);
            Controls.Add(lineNumberLabel);
            Name = "UcTextEditor";
            Size = new Size(300, 150);
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtb;
        private Label lineNumberLabel;
    }
}
