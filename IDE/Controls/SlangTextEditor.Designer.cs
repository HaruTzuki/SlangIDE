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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CbxZoom = new IDE.Controls.FlatCombo();
            this.CbxAvailableMethods = new IDE.Controls.FlatCombo();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.textEditor.Size = new System.Drawing.Size(419, 239);
            this.textEditor.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.CbxZoom);
            this.panel1.Controls.Add(this.CbxAvailableMethods);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.panel1.Size = new System.Drawing.Size(419, 25);
            this.panel1.TabIndex = 1;
            // 
            // CbxZoom
            // 
            this.CbxZoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.CbxZoom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.CbxZoom.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.CbxZoom.Dock = System.Windows.Forms.DockStyle.Right;
            this.CbxZoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbxZoom.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CbxZoom.FormattingEnabled = true;
            this.CbxZoom.Location = new System.Drawing.Point(292, 2);
            this.CbxZoom.Name = "CbxZoom";
            this.CbxZoom.Size = new System.Drawing.Size(127, 21);
            this.CbxZoom.TabIndex = 1;
            this.CbxZoom.SelectedIndexChanged += new System.EventHandler(this.CbxZoom_SelectedIndexChanged);
            this.CbxZoom.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CbxZoom_KeyUp);
            // 
            // CbxAvailableMethods
            // 
            this.CbxAvailableMethods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.CbxAvailableMethods.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.CbxAvailableMethods.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.CbxAvailableMethods.Dock = System.Windows.Forms.DockStyle.Left;
            this.CbxAvailableMethods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbxAvailableMethods.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CbxAvailableMethods.FormattingEnabled = true;
            this.CbxAvailableMethods.Location = new System.Drawing.Point(0, 2);
            this.CbxAvailableMethods.Name = "CbxAvailableMethods";
            this.CbxAvailableMethods.Size = new System.Drawing.Size(258, 21);
            this.CbxAvailableMethods.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textEditor);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 239);
            this.panel2.TabIndex = 2;
            // 
            // SlangTextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 264);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SlangTextEditor";
            this.Load += new System.EventHandler(this.SlangTextEditor_Load);
            this.Shown += new System.EventHandler(this.SlangTextEditor_Shown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public ScintillaNET.Scintilla textEditor;
        private Panel panel1;
        private Panel panel2;
        private FlatCombo CbxAvailableMethods;
        private FlatCombo CbxZoom;
    }
}
