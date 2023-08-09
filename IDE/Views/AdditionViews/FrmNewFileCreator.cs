using IDE.Helper.Custom;

namespace IDE.Views.AdditionViews
{
    public partial class FrmNewFileCreator : SlangIDEForm
    {
        public string FileName { get; private set; }
        public FrmNewFileCreator()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtFileName.Text.Trim()))
            {
                ErrorProvider.SetError(TxtFileName, "Null or empty strings are not allowed");
                ErrorProvider.SetIconPadding(TxtFileName, -25);
                return;
            }

            FileName = TxtFileName.Text.Trim().Replace(" ", "_");

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FrmNewFileCreator_Load(object sender, EventArgs e)
        {
            this.TxtFileName.Focus();
        }

        private void FrmNewFileCreator_Shown(object sender, EventArgs e)
        {
            this.TxtFileName.Focus();
        }
    }
}
