using IDE.Helper.Custom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDE.Views
{
    public partial class FrmAbout : SlangIDEForm
    {
        public FrmAbout()
        {
            InitializeComponent();
        }

        private void BtnLinkedInDimitris_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/dimitris-vlachopoulos/");
        }

        private void BtnLinkedInAlexandros_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/alexandros-mata-186880222/");
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LblWebSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.slang-lang.com");
        }
    }
}
