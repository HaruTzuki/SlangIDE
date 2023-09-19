using IDE.Views.Options;

namespace IDE.Views.AdditionViews
{
    public partial class FrmPreferences : Form
    {
        private UcTextEditorOptions _textEditorOptions;
        private UcLanguageSlangOptions _languageSlangOptions;

        public FrmPreferences()
        {
            InitializeComponent();
            OptionsTreeView.ExpandAll();
            InitialiseOptions();
        }

        private void InitialiseOptions()
        {

            _textEditorOptions = new UcTextEditorOptions();
            _textEditorOptions.Name = "{7BE8FBC4-0302-44A2-AF05-764D95DDF9BD}";
            _textEditorOptions.Visible = false;
            _textEditorOptions.Dock = DockStyle.Fill;


            _languageSlangOptions = new UcLanguageSlangOptions();
            _languageSlangOptions.Name = "{12AB1953-93FD-4790-A6C2-8B1BA75CAB88}";
            _languageSlangOptions.Visible = false;
            _languageSlangOptions.Dock = DockStyle.Fill;



            ControlPanel.Controls.AddRange(new Control[]{ _languageSlangOptions, _textEditorOptions });

        }

        private void OptionsTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            switch (e.Node.Name)
            {
                case "{AF03449E-E928-4A9A-A9B4-737BE6D494C1}": // Text Editor
                    if (_textEditorOptions != null)
                        _textEditorOptions.Visible = true;

                    _textEditorOptions!.BringToFront();
                    break;
                case "{0E4EC421-5BE1-4A5F-B823-DF58E47CD8DF}": // Slang
                    if (_languageSlangOptions != null)
                        _languageSlangOptions.Visible = true;
                    break;
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            _textEditorOptions.Save();
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
