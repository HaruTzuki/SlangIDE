namespace Slang.IDE.Tools.GUIDGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GenerateGuid();
        }

        private void GenerateGuid()
        {
            if (RbtnN.Checked)
            {
                LblGuid.Text = Guid.NewGuid().ToString("N");
            }

            if (RbtnD.Checked)
            {
                LblGuid.Text = Guid.NewGuid().ToString("D");
            }

            if (RbtnB.Checked)
            {
                LblGuid.Text = Guid.NewGuid().ToString("B");
            }

            if (RbtnP.Checked)
            {
                LblGuid.Text = Guid.NewGuid().ToString("P");
            }

            if (RbtnX.Checked)
            {
                LblGuid.Text = Guid.NewGuid().ToString("X");
            }

            LblGuid.Text = LblGuid.Text.Trim().ToUpper();
        }

        private void BtnNewGuid_Click(object sender, EventArgs e)
        {
            GenerateGuid();
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(LblGuid.Text);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            GenerateGuid();
        }
    }
}