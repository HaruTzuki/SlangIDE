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
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(392, 513);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Recent Project";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(386, 483);
            panel1.TabIndex = 0;
            // 
            // BtnNewProject
            // 
            BtnNewProject.BackColor = Color.FromArgb(60, 60, 60);
            BtnNewProject.FlatAppearance.BorderSize = 0;
            BtnNewProject.FlatStyle = FlatStyle.Flat;
            BtnNewProject.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnNewProject.ForeColor = Color.White;
            BtnNewProject.Location = new Point(410, 75);
            BtnNewProject.Name = "BtnNewProject";
            BtnNewProject.Size = new Size(383, 97);
            BtnNewProject.TabIndex = 1;
            BtnNewProject.Text = "Create New Project";
            BtnNewProject.UseVisualStyleBackColor = false;
            BtnNewProject.Click += BtnNewProject_Click;
            // 
            // FrmStartup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 36, 36);
            ClientSize = new Size(805, 537);
            Controls.Add(BtnNewProject);
            Controls.Add(groupBox1);
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