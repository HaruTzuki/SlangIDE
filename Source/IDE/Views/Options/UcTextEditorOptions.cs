using IDE.Properties;
using Slang.IDE.Shared.Extensions;
using System.Data;
using System.Drawing.Text;

namespace IDE.Views.Options
{
    public partial class UcTextEditorOptions : UserControl
    {
        private int[] _sizes = new int[] { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
        public UcTextEditorOptions()
        {
            InitializeComponent();
            LoadFonts();
            InitialiseSizes();
            GetSaved();
        }

        private void InitialiseSizes()
        {
            CbxSizes.DataSource = _sizes.Select(x => new KeyValuePair<int, int>(x, x)).ToList();
            CbxSizes.DisplayMember = "Key";
            CbxSizes.ValueMember = "Value";
        }

        private void GetSaved()
        {
            CbxFonts.SelectedValue = Settings.Default["TextEditorFont"].ToString();
            CbxSizes.SelectedValue = Settings.Default["TextEditorFontSize"].AsInt();
            IsBold.Checked = Settings.Default["TextEditorBold"].AsBool();
            IsItalic.Checked = Settings.Default["TextEditorItalic"].AsBool();
        }

        private void LoadFonts()
        {
            using var fontCollection = new InstalledFontCollection();

            CbxFonts.DataSource = fontCollection.Families;
            CbxFonts.DisplayMember = "Name";
            CbxFonts.ValueMember = "Name";
        }

        private void BtnResetDefault_Click(object sender, EventArgs e)
        {
            Settings.Default["TextEditorFont"] = "Consolas";
            Settings.Default["TextEditorFontSize"] = 16;
            Settings.Default["TextEditorBold"] = true;
            Settings.Default["TextEditorItalic"] = false;
        }

        public void Save()
        {
            Settings.Default["TextEditorFont"] = CbxFonts.SelectedValue;
            Settings.Default["TextEditorFontSize"] = CbxSizes.SelectedValue.AsInt();
            Settings.Default["TextEditorBold"] = IsBold.Checked;
            Settings.Default["TextEditorItalic"] = IsItalic.Checked;
        }
    }
}
