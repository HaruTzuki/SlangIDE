using WeifenLuo.WinFormsUI.Docking;

namespace IDE.Abstraction
{
    public partial class ToolWindow : DockContent
    {
        public ToolWindow()
        {
            InitializeComponent();
            AutoScaleMode = AutoScaleMode.Dpi;
            Width = 250;
        }
    }
}
