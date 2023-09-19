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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStartup));
            this.BtnNewProject = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Body = new System.Windows.Forms.Panel();
            this.BtnLoadSlangProject = new System.Windows.Forms.Button();
            this.recentProjectGroup = new System.Windows.Forms.GroupBox();
            this.recentProjectPanel = new System.Windows.Forms.Panel();
            this.recentProjectGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnNewProject
            // 
            this.BtnNewProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNewProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnNewProject.FlatAppearance.BorderSize = 0;
            this.BtnNewProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNewProject.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.BtnNewProject.ForeColor = System.Drawing.Color.White;
            this.BtnNewProject.Location = new System.Drawing.Point(336, 20);
            this.BtnNewProject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnNewProject.Name = "BtnNewProject";
            this.BtnNewProject.Size = new System.Drawing.Size(269, 85);
            this.BtnNewProject.TabIndex = 1;
            this.BtnNewProject.Text = "Create New Project";
            this.BtnNewProject.UseVisualStyleBackColor = false;
            this.BtnNewProject.Click += new System.EventHandler(this.BtnNewProject_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 327);
            this.panel1.TabIndex = 0;
            // 
            // Body
            // 
            this.Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Body.Location = new System.Drawing.Point(0, 34);
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(814, 395);
            this.Body.TabIndex = 1;
            // 
            // BtnLoadSlangProject
            // 
            this.BtnLoadSlangProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLoadSlangProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnLoadSlangProject.FlatAppearance.BorderSize = 0;
            this.BtnLoadSlangProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLoadSlangProject.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.BtnLoadSlangProject.ForeColor = System.Drawing.Color.White;
            this.BtnLoadSlangProject.Location = new System.Drawing.Point(336, 109);
            this.BtnLoadSlangProject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnLoadSlangProject.Name = "BtnLoadSlangProject";
            this.BtnLoadSlangProject.Size = new System.Drawing.Size(269, 85);
            this.BtnLoadSlangProject.TabIndex = 3;
            this.BtnLoadSlangProject.Text = "Load Slang Project";
            this.BtnLoadSlangProject.UseVisualStyleBackColor = false;
            this.BtnLoadSlangProject.Click += new System.EventHandler(this.BtnLoadSlangProject_Click);
            // 
            // recentProjectGroup
            // 
            this.recentProjectGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.recentProjectGroup.Controls.Add(this.recentProjectPanel);
            this.recentProjectGroup.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.recentProjectGroup.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.recentProjectGroup.Location = new System.Drawing.Point(9, 10);
            this.recentProjectGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.recentProjectGroup.Name = "recentProjectGroup";
            this.recentProjectGroup.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.recentProjectGroup.Size = new System.Drawing.Size(296, 375);
            this.recentProjectGroup.TabIndex = 2;
            this.recentProjectGroup.TabStop = false;
            this.recentProjectGroup.Text = "Recent Project";
            // 
            // recentProjectPanel
            // 
            this.recentProjectPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recentProjectPanel.Location = new System.Drawing.Point(2, 18);
            this.recentProjectPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.recentProjectPanel.Name = "recentProjectPanel";
            this.recentProjectPanel.Size = new System.Drawing.Size(292, 355);
            this.recentProjectPanel.TabIndex = 0;
            // 
            // FrmStartup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(614, 395);
            this.Controls.Add(this.BtnNewProject);
            this.Controls.Add(this.recentProjectGroup);
            this.Controls.Add(this.BtnLoadSlangProject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStartup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start up";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmStartup_FormClosed);
            this.recentProjectGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnNewProject;
        private Panel panel1;
        private Panel Body;
        private GroupBox recentProjectGroup;
        private Panel recentProjectPanel;
        private Button BtnLoadSlangProject;
    }
}