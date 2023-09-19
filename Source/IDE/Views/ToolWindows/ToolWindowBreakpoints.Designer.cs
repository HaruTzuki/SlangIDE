namespace IDE.Views.ToolWindows
{
    partial class ToolWindowBreakpoints
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
            this.BreakpointListView = new System.Windows.Forms.ListView();
            this.BreakpointColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LineNumberColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // BreakpointListView
            // 
            this.BreakpointListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BreakpointColumn,
            this.FileColumn,
            this.LineNumberColumn});
            this.BreakpointListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BreakpointListView.HideSelection = false;
            this.BreakpointListView.Location = new System.Drawing.Point(0, 0);
            this.BreakpointListView.Name = "BreakpointListView";
            this.BreakpointListView.Size = new System.Drawing.Size(654, 278);
            this.BreakpointListView.TabIndex = 0;
            this.BreakpointListView.UseCompatibleStateImageBehavior = false;
            this.BreakpointListView.View = System.Windows.Forms.View.Details;
            // 
            // BreakpointColumn
            // 
            this.BreakpointColumn.Text = "Breakpoint";
            this.BreakpointColumn.Width = 150;
            // 
            // FileColumn
            // 
            this.FileColumn.Text = "File Location";
            this.FileColumn.Width = 300;
            // 
            // LineNumberColumn
            // 
            this.LineNumberColumn.Text = "Line Number";
            this.LineNumberColumn.Width = 100;
            // 
            // ToolWindowBreakpoints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 278);
            this.Controls.Add(this.BreakpointListView);
            this.Name = "ToolWindowBreakpoints";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TabText = "Breakpoints";
            this.Text = "Breakpoints";
            this.Load += new System.EventHandler(this.ToolWindowBreakpoints_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView BreakpointListView;
        private ColumnHeader BreakpointColumn;
        private ColumnHeader FileColumn;
        private ColumnHeader LineNumberColumn;
    }
}