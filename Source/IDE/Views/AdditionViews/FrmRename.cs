using IDE.Helper.Custom;

namespace IDE.Views.AdditionViews
{
    public partial class FrmRename : SlangIDEForm
    {
        public string FileName { get; private set; }

        public FrmRename(string fromFile)
        {
            InitializeComponent();
            TxtFrom.Text = fromFile;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtTo.Text))
            {
                ErrorProvider.SetError(TxtTo, "Null or empty strings are not allowed");
                ErrorProvider.SetIconPadding(TxtTo, -25);
                return;
            }

            FileName = TxtTo.Text.Trim().Replace(" ", "_");
            DialogResult = DialogResult.OK; if (string.IsNullOrEmpty(TxtTo.Text))
            {
                ErrorProvider.SetError(TxtTo, "Null or empty strings are not allowed");
                ErrorProvider.SetIconPadding(TxtTo, -25);
                return;
            }

            FileName = TxtTo.Text.Trim().Replace(" ", "_");
            DialogResult = DialogResult.OK;
        }
    }
}
