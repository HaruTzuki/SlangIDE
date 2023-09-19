using IDE.Abstraction;
using Slang.IDE.Shared.Helpers;

namespace IDE.Views.ToolWindows
{
    public partial class ToolWindowOutput : ToolWindow
    {
        #region Constants
        private const int TERMINAL_DEFAULT_FORE_COLOUR = 0xcccccc;
        private const int TERMINAL_DEFAULT_BACK_COLOUR = 0x0c0c0c;
        #endregion

        public ToolWindowOutput()
        {
            InitializeComponent();
            ColourInitialise();
            TxtOutput.ReadOnly = true;
            DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.DockBottom | WeifenLuo.WinFormsUI.Docking.DockAreas.Document;
        }

        private void ColourInitialise()
        {
            TxtOutput.Font = new Font("Consolas", 10, FontStyle.Bold);
            TxtOutput.BackColor = ColourHelper.IntToColour(TERMINAL_DEFAULT_BACK_COLOUR);
            TxtOutput.ForeColor = ColourHelper.IntToColour(TERMINAL_DEFAULT_FORE_COLOUR);
        }

        public void WriteLine(string text)
        {
            WriteLine(text, ColourHelper.IntToColour(TERMINAL_DEFAULT_FORE_COLOUR));
        }

        delegate void WriteLineCallback(string text, Color color);

        public void WriteLine(string text, Color color)
        {
            if (TxtOutput.InvokeRequired)
            {
                WriteLineCallback d = new WriteLineCallback(WriteLine);
                TxtOutput.Invoke(d, new object[] { text, color });
                return;
            }

            text += Environment.NewLine;

            TxtOutput.SelectionStart = TxtOutput.TextLength;
            TxtOutput.SelectionLength = 0;

            TxtOutput.SelectionColor = color;
            TxtOutput.AppendText(text);
            TxtOutput.SelectionColor = TxtOutput.ForeColor;
        }

        public void Write(string text)
        {
            Write(text, ColourHelper.IntToColour(TERMINAL_DEFAULT_FORE_COLOUR));
        }

        public void Write(string text, Color color)
        {
            var lastPosition = TxtOutput.Text.Length;
            var selectionLength = text.Length;
            TxtOutput.Text += text;
            TxtOutput.SelectionStart = lastPosition;
            TxtOutput.SelectionLength = selectionLength;
            TxtOutput.SelectionColor = color;
        }

        public void Clear()
        {
            TxtOutput.Text = string.Empty;
        }
    }
}
