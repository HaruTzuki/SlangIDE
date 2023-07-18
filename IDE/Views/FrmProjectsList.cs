using IDE.Helper;
using IDE.Helper.Custom;
using IDE.Preferences;
using Newtonsoft.Json;
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
    public partial class FrmProjectsList : SlangIDEForm
    {
        public FrmProjectsList()
        {
            InitializeComponent();
            AllowResizing = false;
            TxtFilePath.Text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "GoSlang");
            TemplatesListView.Items[0].Selected = true;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            var selectedProjectType = ReadPredefineProject(this.TemplatesListView.SelectedItems[0].Tag.ToString()!);
            selectedProjectType.Name = TxtProjectName.Text;

            Functions.CreateProject(TxtFilePath.Text, TxtProjectName.Text, selectedProjectType);


            var form = new FrmMain();
            this.Hide();
            form.ShowDialog();
        }

        private Templates ReadPredefineProject(string tag)
        {
            using var sr = new StreamReader($"Templates/Projects/{tag}.json");
            var json = sr.ReadToEnd();

            return JsonConvert.DeserializeObject<Templates>(json)!;
        }
    }
}
