using IDE.Controls;
using IDE.Helper;
using IDE.Helper.Custom;
using IDE.Preferences;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDE.Views
{
    public partial class FrmMain : SlangIDEForm
    {
        private readonly Templates _templates;
        public static UcTabControl SlangTabControl;
        public FrmMain()
        {
            InitializeComponent();
            this.FileExplorer.BuildTreeView();
            var s = new Preferences.Shortcut();
            s.Bind();
            AllowResizing = true;
            CustomUI.Title = $"{Sessions.SlangProject.Name} - Slang IDE";

            PaintAllComponents();
        }

        private void PaintAllComponents()
        {
            /* Menu Items */
            #region Headers
            var _file = new ToolStripMenuItem();
            _file.Text = "&File";
            _file.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _file.Name = "{2AD31557-A841-47E2-835B-6BCAE286E486}";

            var _edit = new ToolStripMenuItem();
            _edit.Text = "&Edit";
            _edit.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _edit.Name = "{3CB0541E-C0B1-499B-BB10-05C17E8E25A7}";

            var _build = new ToolStripMenuItem();
            _build.Text = "&Build";
            _build.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _build.Name = "{1E4E671A-3C4D-44AD-BFE5-E8C525A7A363}";

            var _options = new ToolStripMenuItem();
            _options.Text = "&Options";
            _options.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _options.Name = "{BAE30586-48BC-44A8-AF3E-BA2399D74B18}";

            var _title = new ToolStripLabel();
            _title.Text = $"{Sessions.SlangProject.Name} - Slang IDE";
            _title.BackColor = Color.FromArgb(61, 61, 61);
            _title.ForeColor = Color.WhiteSmoke;
            //Add these controls to main menu
            CustomUI.MainMenu.Items.Add(new ToolStripSeparator());
            CustomUI.MainMenu.Items.AddRange(new ToolStripMenuItem[] { _file, _edit, _build, _options });
            CustomUI.MainMenu.ForeColor = Color.WhiteSmoke;
            #endregion

            SlangTabControl = new UcTabControl();
            PanelContainer.Panel2.Controls.Add(SlangTabControl);
            SlangTabControl.Dock = DockStyle.Fill;

        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Tsi_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        //{
        //    if (SystemPreferences.Shortcuts.ContainsKey(keyData))
        //    {
        //        SystemPreferences.Shortcuts[keyData].Invoke();
        //        return true;
        //    }

        //    return base.ProcessCmdKey(ref msg, keyData);
        //}
    }
}
