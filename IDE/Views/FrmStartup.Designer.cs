namespace IDE.Views
{
    partial class FrmStartup
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
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            BtnNewProject = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(10, 2);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(343, 355);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Recent Project";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 22);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(337, 331);
            panel1.TabIndex = 0;
            // 
            // BtnNewProject
            // 
            BtnNewProject.BackColor = Color.FromArgb(60, 60, 60);
            BtnNewProject.FlatAppearance.BorderSize = 0;
            BtnNewProject.FlatStyle = FlatStyle.Flat;
            BtnNewProject.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnNewProject.ForeColor = Color.White;
            BtnNewProject.Location = new Point(359, 12);
            BtnNewProject.Margin = new Padding(3, 2, 3, 2);
            BtnNewProject.Name = "BtnNewProject";
            BtnNewProject.Size = new Size(335, 73);
            BtnNewProject.TabIndex = 1;
            BtnNewProject.Text = "Create New Project";
            BtnNewProject.UseVisualStyleBackColor = false;
            BtnNewProject.Click += BtnNewProject_Click;
            // 
            // FrmStartup
            // 
            AllowResizing = false;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 36, 36);
            BorderColour = Color.DarkSlateBlue;
            ClientSize = new Size(704, 403);
            FormClosingOperations = Helper.Custom.FormClosingOperations.CloseApplication;
            FormTitle = "Slang IDE";
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmStartup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmStartup";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button BtnNewProject;
        private Panel panel1;
    }
}