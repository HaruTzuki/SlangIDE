namespace IDE.Controls
{
    partial class SlangTextEditor
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
            this.textEditor = new ScintillaNET.Scintilla();
            this.SuspendLayout();
            // 
            // textEditor
            // 
            this.textEditor.AutomaticFold = ((ScintillaNET.AutomaticFold)(((ScintillaNET.AutomaticFold.Show | ScintillaNET.AutomaticFold.Click) 
            | ScintillaNET.AutomaticFold.Change)));
            this.textEditor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textEditor.CaretForeColor = System.Drawing.Color.WhiteSmoke;
            this.textEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEditor.Location = new System.Drawing.Point(0, 0);
            this.textEditor.Name = "textEditor";
            this.textEditor.Size = new System.Drawing.Size(435, 303);
            this.textEditor.TabIndex = 0;
            // 
            // SlangTextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textEditor);
            this.Name = "SlangTextEditor";
            this.Size = new System.Drawing.Size(435, 303);
            this.Load += new System.EventHandler(this.SlangTextEditor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public ScintillaNET.Scintilla textEditor;
    }
}
