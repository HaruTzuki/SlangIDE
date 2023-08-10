using IDE.Helper;
using IDE.Preferences;
using Newtonsoft.Json;

namespace IDE.Views
{
    public partial class FrmProjectsList : Form
    {
        public FrmProjectsList()
        {
            InitializeComponent();
            TxtFilePath.Text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Slang");
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

        private void FrmProjectsList_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
