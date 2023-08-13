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
            this.CbxAvailableMethods = new IDE.Controls.FlatCombo();
            this.CbxZoom = new IDE.Controls.FlatCombo();
            this.panel2 = new System.Windows.Forms.Panel();
            this.incrementalSearch1 = new IDE.Views.TextEditorViews.IncrementalSearch();
            this.PnlBookmark = new System.Windows.Forms.Panel();
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
            this.textEditor.Size = new System.Drawing.Size(397, 239);
            this.textEditor.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.CbxAvailableMethods);
            this.panel1.Controls.Add(this.CbxZoom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.panel1.Size = new System.Drawing.Size(419, 25);
            this.panel1.TabIndex = 1;
            // 
            // CbxAvailableMethods
            // 
            this.CbxAvailableMethods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.CbxAvailableMethods.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.CbxAvailableMethods.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.CbxAvailableMethods.Dock = System.Windows.Forms.DockStyle.Right;
            this.CbxAvailableMethods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbxAvailableMethods.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CbxAvailableMethods.FormattingEnabled = true;
            this.CbxAvailableMethods.Location = new System.Drawing.Point(34, 2);
            this.CbxAvailableMethods.Name = "CbxAvailableMethods";
            this.CbxAvailableMethods.Size = new System.Drawing.Size(258, 21);
            this.CbxAvailableMethods.TabIndex = 0;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.incrementalSearch1);
            this.panel2.Controls.Add(this.textEditor);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 239);
            this.panel2.TabIndex = 2;
            // 
            // incrementalSearch1
            // 
            this.incrementalSearch1.AutoPosition = false;
            this.incrementalSearch1.AutoSize = true;
            this.incrementalSearch1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.incrementalSearch1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.incrementalSearch1.FindReplace = null;
            this.incrementalSearch1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incrementalSearch1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.incrementalSearch1.Location = new System.Drawing.Point(9, 9);
            this.incrementalSearch1.Name = "incrementalSearch1";
            this.incrementalSearch1.Size = new System.Drawing.Size(0, 5);
            this.incrementalSearch1.TabIndex = 1;
            this.incrementalSearch1.TextEditor = null;
            this.incrementalSearch1.ToolItem = true;
            // 
            // PnlBookmark
            // 
            this.PnlBookmark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.PnlBookmark.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlBookmark.Location = new System.Drawing.Point(397, 25);
            this.PnlBookmark.Name = "PnlBookmark";
            this.PnlBookmark.Size = new System.Drawing.Size(22, 239);
            this.PnlBookmark.TabIndex = 2;
            this.PnlBookmark.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlBookmark_Paint);
            // 
            // SlangTextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 264);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PnlBookmark);
            this.Controls.Add(this.panel1);
            this.Name = "SlangTextEditor";
            this.Load += new System.EventHandler(this.SlangTextEditor_Load);
            this.Shown += new System.EventHandler(this.SlangTextEditor_Shown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public ScintillaNET.Scintilla textEditor;
        private Panel panel1;
        private Panel panel2;
        private FlatCombo CbxAvailableMethods;
        private FlatCombo CbxZoom;
        private Views.TextEditorViews.IncrementalSearch incrementalSearch1;
        private Panel PnlBookmark;
    }
}
