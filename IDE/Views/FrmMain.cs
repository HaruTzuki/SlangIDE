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
        public FrmMain()
        {
            InitializeComponent();
            this.ucFileExplorer1.BuildTreeView();
            //text_editor.EditorText = _templates.Code;
            var s = new Preferences.Shortcut();
            s.Bind();
            
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FrmMain_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {

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
