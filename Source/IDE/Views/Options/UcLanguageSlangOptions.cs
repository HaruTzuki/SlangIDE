using IDE.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDE.Views.Options
{
    public partial class UcLanguageSlangOptions : UserControl
    {
        public UcLanguageSlangOptions()
        {
            InitializeComponent();
            TxtMiddlewarePath.Text = Settings.Default.SlangMiddlewarePath;
            TxtCliPath.Text = Settings.Default.SlangCLIPath;
        }
    }
}
