namespace IDE.Views.AdditionViews
{
    partial class FrmPreferences
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Basic");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Shortcuts");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Editor", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPreferences));
            this.BasicSettingsTab = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.OptionsTreeView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // BasicSettingsTab
            // 
            this.BasicSettingsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BasicSettingsTab.Location = new System.Drawing.Point(4, 29);
            this.BasicSettingsTab.Name = "BasicSettingsTab";
            this.BasicSettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.BasicSettingsTab.Size = new System.Drawing.Size(814, 483);
            this.BasicSettingsTab.TabIndex = 0;
            this.BasicSettingsTab.Text = "Basic Settings";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage2.Size = new System.Drawing.Size(814, 483);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Editor";
            // 
            // OptionsTreeView
            // 
            this.OptionsTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.OptionsTreeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OptionsTreeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.OptionsTreeView.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.OptionsTreeView.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.OptionsTreeView.Location = new System.Drawing.Point(0, 0);
            this.OptionsTreeView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OptionsTreeView.Name = "OptionsTreeView";
            treeNode1.Name = "{AF03449E-E928-4A9A-A9B4-737BE6D494C1}";
            treeNode1.Text = "Basic";
            treeNode2.Name = "{C205C943-2137-4EEE-9D8F-54F90A2CD3DA}";
            treeNode2.Text = "General";
            treeNode3.Name = "{07ED30D6-FE3E-4204-A03D-BEC14107DFEA}";
            treeNode3.Text = "Shortcuts";
            treeNode4.Name = "{B851D9E9-375F-4506-A9F2-05D8057720D7}";
            treeNode4.Text = "Editor";
            this.OptionsTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4});
            this.OptionsTreeView.ShowPlusMinus = false;
            this.OptionsTreeView.Size = new System.Drawing.Size(183, 450);
            this.OptionsTreeView.TabIndex = 0;
            // 
            // FrmPreferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(714, 450);
            this.Controls.Add(this.OptionsTreeView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPreferences";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preferences";
            this.ResumeLayout(false);

        }

        #endregion
        private TabPage BasicSettingsTab;
        private TabPage tabPage2;
        private TreeView OptionsTreeView;
    }
}