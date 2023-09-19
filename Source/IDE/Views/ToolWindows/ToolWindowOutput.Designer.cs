namespace IDE.Views.ToolWindows
{
    partial class ToolWindowOutput
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
            this.TxtOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // TxtOutput
            // 
            this.TxtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtOutput.Location = new System.Drawing.Point(0, 0);
            this.TxtOutput.Name = "TxtOutput";
            this.TxtOutput.Size = new System.Drawing.Size(452, 214);
            this.TxtOutput.TabIndex = 0;
            this.TxtOutput.Text = "";
            // 
            // ToolWindowOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 214);
            this.Controls.Add(this.TxtOutput);
            this.Name = "ToolWindowOutput";
            this.TabText = "Output";
            this.Text = "Output";
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox TxtOutput;
    }
}