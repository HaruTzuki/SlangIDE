namespace IDE.Views.AdditionViews
{
    partial class FrmFindReplace
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
            label1 = new Label();
            TitleBar = new Panel();
            LblTitle = new Label();
            BtnMinimize = new Button();
            BtnMaximize = new Button();
            button1 = new Button();
            TxtFind = new TextBox();
            TxtReplace = new TextBox();
            LblReplace = new Label();
            BtnFindAll = new Button();
            BtnFindNext = new Button();
            BtnReplaceAll = new Button();
            BtnReplace = new Button();
            PnlReplaceButtons = new Panel();
            PnlFindButtons = new Panel();
            BtnShowReplace = new Button();
            TitleBar.SuspendLayout();
            PnlReplaceButtons.SuspendLayout();
            PnlFindButtons.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 56);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 0;
            label1.Text = "Find:";
            // 
            // TitleBar
            // 
            TitleBar.BackColor = Color.FromArgb(31, 31, 31);
            TitleBar.Controls.Add(LblTitle);
            TitleBar.Controls.Add(BtnMinimize);
            TitleBar.Controls.Add(BtnMaximize);
            TitleBar.Controls.Add(button1);
            TitleBar.Dock = DockStyle.Top;
            TitleBar.Location = new Point(0, 0);
            TitleBar.Name = "TitleBar";
            TitleBar.Size = new Size(531, 32);
            TitleBar.TabIndex = 1;
            TitleBar.MouseDown += TitleBar_MouseDown;
            TitleBar.MouseMove += TitleBar_MouseMove;
            TitleBar.MouseUp += TitleBar_MouseUp;
            // 
            // LblTitle
            // 
            LblTitle.Dock = DockStyle.Left;
            LblTitle.Location = new Point(0, 0);
            LblTitle.Name = "LblTitle";
            LblTitle.Size = new Size(100, 32);
            LblTitle.TabIndex = 3;
            LblTitle.Text = "Find && Replace";
            LblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BtnMinimize
            // 
            BtnMinimize.Dock = DockStyle.Right;
            BtnMinimize.FlatAppearance.BorderSize = 0;
            BtnMinimize.FlatStyle = FlatStyle.Flat;
            BtnMinimize.ForeColor = Color.WhiteSmoke;
            BtnMinimize.Location = new Point(381, 0);
            BtnMinimize.Name = "BtnMinimize";
            BtnMinimize.Size = new Size(50, 32);
            BtnMinimize.TabIndex = 2;
            BtnMinimize.Text = "—";
            BtnMinimize.UseVisualStyleBackColor = true;
            BtnMinimize.Click += BtnMinimize_Click;
            // 
            // BtnMaximize
            // 
            BtnMaximize.Dock = DockStyle.Right;
            BtnMaximize.FlatAppearance.BorderSize = 0;
            BtnMaximize.FlatStyle = FlatStyle.Flat;
            BtnMaximize.ForeColor = Color.WhiteSmoke;
            BtnMaximize.Location = new Point(431, 0);
            BtnMaximize.Name = "BtnMaximize";
            BtnMaximize.Size = new Size(50, 32);
            BtnMaximize.TabIndex = 1;
            BtnMaximize.Text = "[]";
            BtnMaximize.UseVisualStyleBackColor = true;
            BtnMaximize.Click += BtnMaximize_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(481, 0);
            button1.Name = "button1";
            button1.Size = new Size(50, 32);
            button1.TabIndex = 0;
            button1.Text = "❌";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TxtFind
            // 
            TxtFind.BackColor = Color.FromArgb(56, 56, 56);
            TxtFind.BorderStyle = BorderStyle.FixedSingle;
            TxtFind.ForeColor = Color.WhiteSmoke;
            TxtFind.Location = new Point(60, 53);
            TxtFind.Name = "TxtFind";
            TxtFind.Size = new Size(435, 23);
            TxtFind.TabIndex = 2;
            // 
            // TxtReplace
            // 
            TxtReplace.BackColor = Color.FromArgb(56, 56, 56);
            TxtReplace.BorderStyle = BorderStyle.FixedSingle;
            TxtReplace.ForeColor = Color.WhiteSmoke;
            TxtReplace.Location = new Point(60, 82);
            TxtReplace.Name = "TxtReplace";
            TxtReplace.Size = new Size(435, 23);
            TxtReplace.TabIndex = 4;
            TxtReplace.Visible = false;
            // 
            // LblReplace
            // 
            LblReplace.AutoSize = true;
            LblReplace.Location = new Point(3, 84);
            LblReplace.Name = "LblReplace";
            LblReplace.Size = new Size(51, 15);
            LblReplace.TabIndex = 3;
            LblReplace.Text = "Replace:";
            LblReplace.Visible = false;
            // 
            // BtnFindAll
            // 
            BtnFindAll.BackColor = Color.FromArgb(172, 84, 26);
            BtnFindAll.FlatAppearance.BorderSize = 0;
            BtnFindAll.FlatStyle = FlatStyle.Flat;
            BtnFindAll.Location = new Point(18, 39);
            BtnFindAll.Name = "BtnFindAll";
            BtnFindAll.Size = new Size(75, 23);
            BtnFindAll.TabIndex = 5;
            BtnFindAll.Text = "Find All";
            BtnFindAll.UseVisualStyleBackColor = false;
            // 
            // BtnFindNext
            // 
            BtnFindNext.BackColor = Color.FromArgb(172, 84, 26);
            BtnFindNext.FlatAppearance.BorderSize = 0;
            BtnFindNext.FlatStyle = FlatStyle.Flat;
            BtnFindNext.Location = new Point(18, 10);
            BtnFindNext.Name = "BtnFindNext";
            BtnFindNext.Size = new Size(75, 23);
            BtnFindNext.TabIndex = 6;
            BtnFindNext.Text = "Find Next";
            BtnFindNext.UseVisualStyleBackColor = false;
            BtnFindNext.Click += BtnFindNext_Click;
            // 
            // BtnReplaceAll
            // 
            BtnReplaceAll.BackColor = Color.FromArgb(172, 84, 26);
            BtnReplaceAll.FlatAppearance.BorderSize = 0;
            BtnReplaceAll.FlatStyle = FlatStyle.Flat;
            BtnReplaceAll.Location = new Point(13, 39);
            BtnReplaceAll.Name = "BtnReplaceAll";
            BtnReplaceAll.Size = new Size(75, 23);
            BtnReplaceAll.TabIndex = 7;
            BtnReplaceAll.Text = "Replace All";
            BtnReplaceAll.UseVisualStyleBackColor = false;
            // 
            // BtnReplace
            // 
            BtnReplace.BackColor = Color.FromArgb(172, 84, 26);
            BtnReplace.FlatAppearance.BorderSize = 0;
            BtnReplace.FlatStyle = FlatStyle.Flat;
            BtnReplace.Location = new Point(13, 10);
            BtnReplace.Name = "BtnReplace";
            BtnReplace.Size = new Size(75, 23);
            BtnReplace.TabIndex = 8;
            BtnReplace.Text = "Replace";
            BtnReplace.UseVisualStyleBackColor = false;
            // 
            // PnlReplaceButtons
            // 
            PnlReplaceButtons.Controls.Add(BtnReplaceAll);
            PnlReplaceButtons.Controls.Add(BtnReplace);
            PnlReplaceButtons.Location = new Point(292, 111);
            PnlReplaceButtons.Name = "PnlReplaceButtons";
            PnlReplaceButtons.Size = new Size(95, 69);
            PnlReplaceButtons.TabIndex = 9;
            PnlReplaceButtons.Visible = false;
            // 
            // PnlFindButtons
            // 
            PnlFindButtons.Controls.Add(BtnFindAll);
            PnlFindButtons.Controls.Add(BtnFindNext);
            PnlFindButtons.Location = new Point(393, 111);
            PnlFindButtons.Name = "PnlFindButtons";
            PnlFindButtons.Size = new Size(102, 66);
            PnlFindButtons.TabIndex = 10;
            // 
            // BtnShowReplace
            // 
            BtnShowReplace.FlatAppearance.BorderSize = 0;
            BtnShowReplace.FlatStyle = FlatStyle.Flat;
            BtnShowReplace.Location = new Point(497, 52);
            BtnShowReplace.Name = "BtnShowReplace";
            BtnShowReplace.Size = new Size(30, 23);
            BtnShowReplace.TabIndex = 11;
            BtnShowReplace.Text = "^";
            BtnShowReplace.UseVisualStyleBackColor = true;
            BtnShowReplace.Click += BtnShowReplace_Click;
            // 
            // FrmFindReplace
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(531, 185);
            Controls.Add(BtnShowReplace);
            Controls.Add(TxtReplace);
            Controls.Add(LblReplace);
            Controls.Add(TxtFind);
            Controls.Add(TitleBar);
            Controls.Add(label1);
            Controls.Add(PnlReplaceButtons);
            Controls.Add(PnlFindButtons);
            ForeColor = Color.WhiteSmoke;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmFindReplace";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmFindReplace";
            Paint += FrmFindReplace_Paint;
            MouseDown += FrmFindReplace_MouseDown;
            MouseMove += FrmFindReplace_MouseMove;
            MouseUp += FrmFindReplace_MouseUp;
            Resize += FrmFindReplace_Resize;
            TitleBar.ResumeLayout(false);
            PnlReplaceButtons.ResumeLayout(false);
            PnlFindButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel TitleBar;
        private Button BtnMinimize;
        private Button BtnMaximize;
        private Button button1;
        private Label LblTitle;
        private TextBox TxtFind;
        private TextBox TxtReplace;
        private Label LblReplace;
        private Button BtnFindAll;
        private Button BtnFindNext;
        private Button BtnReplaceAll;
        private Button BtnReplace;
        private Panel PnlReplaceButtons;
        private Panel PnlFindButtons;
        private Button BtnShowReplace;
    }
}