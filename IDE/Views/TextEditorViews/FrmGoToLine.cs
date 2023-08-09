using Slang.IDE.Shared.Extensions;

namespace IDE.Views.TextEditorViews
{
    public partial class FrmGoToLine : Form
    {
        private int _maximunLine = 0;

        public int ReturnedLine = 0;
        public FrmGoToLine(int currentLine, int maxLine)
        {
            InitializeComponent();
            LblTitle.Text = $"Line (1 - {maxLine}):";
            TxtLine.Text = (currentLine+1).ToString();
            _maximunLine = maxLine;
        }

        private void TxtLine_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            SanityChecks();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            SanityChecks();
            ReturnedLine = TxtLine.Text.AsInt() - 1;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void SanityChecks()
        {
            if (TxtLine.Text.AsInt() > _maximunLine)
            {
                ErrorProvider.SetError(TxtLine, $"The number exceeds the {_maximunLine}");
                ErrorProvider.SetIconPadding(TxtLine, -25);
                return;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
