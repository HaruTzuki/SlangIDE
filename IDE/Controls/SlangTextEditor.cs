using Microsoft.VisualBasic;
using ScintillaNET;
using Slang.IDE.Shared.Helpers;
using System.Text.RegularExpressions;

namespace IDE.Controls
{
    public partial class SlangTextEditor : UserControl
    {
        #region Constants
        private const int NUMBER_MARGIN = 1;
        private const int BOOKMARK_MARGIN = 2;
        private const int BOOKMARK_MARKER = 2;
        private const int FOLDING_MARGIN = 3;
        private const bool CODEFOLDING_CIRCULAR = true;

        #region Code Indent Handlers
        const int SCI_SETLINEINDENTATION = 2126;
        const int SCI_GETLINEINDENTATION = 2127;
        #endregion
        #endregion

        #region Public Properties
        public string EditorText
        {
            get
            {
                return textEditor.Text;
            }
            set
            {
                textEditor.Text = value;
            }
        }
        #endregion

        #region Events 
        public event EventHandler<CaretPositionEventArgs> CaretPositionChanged;
        #endregion

        public SlangTextEditor()
        {
            InitializeComponent();
            SetupInitSettings();
            InitEvents();
        }

        private void InitEvents()
        {
            textEditor.MarginClick += TextEditor_MarginClick;
            textEditor.InsertCheck += TextEditor_InsertCheck;
            textEditor.CharAdded += TextEditor_CharAdded;
            textEditor.KeyUp += TextEditor_KeyUp;
            textEditor.MouseUp += TextEditor_MouseUp;
        }

        private void TextEditor_MouseUp(object sender, MouseEventArgs e)
        {
            CaretPositionChanged(this, new CaretPositionEventArgs { Line = textEditor.CurrentLine + 1, Column = textEditor.CurrentPosition + 1 });
        }


        private void TextEditor_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter 
                || e.KeyCode == Keys.Up
                || e.KeyCode == Keys.Down
                || e.KeyCode == Keys.Right
                || e.KeyCode == Keys.Left)
            {
                CaretPositionChanged(this, new CaretPositionEventArgs { Line = textEditor.CurrentLine + 1, Column = textEditor.CurrentPosition + 1 });
            }
        }

        private void SetupInitSettings()
        {
            textEditor.IndentationGuides = IndentView.LookBoth;
        }

        private void SlangTextEditor_Load(object sender, EventArgs e)
        {
            InitColours();
            InitSyntaxHighlitning();
            InitNumberMargin();
            InitBookmarkMargin();
            InitCodeFolding();
        }

        private void InitColours()
        {
            textEditor.SetSelectionBackColor(true, ColourHelper.IntToColour(0x114D9C));
            textEditor.StyleResetDefault();
            textEditor.Styles[Style.Default].Font = "Consolas";
            textEditor.Styles[Style.Default].Size = 12;
            textEditor.Styles[Style.Default].Bold = true;
            textEditor.Styles[Style.Default].BackColor = ColourHelper.IntToColour(0x313131);
            textEditor.Styles[Style.Default].ForeColor = ColourHelper.IntToColour(0xF5F5F5);
            textEditor.CaretForeColor = Color.WhiteSmoke;
            textEditor.StyleClearAll();
        }

        private void InitSyntaxHighlitning()
        {
            textEditor.Lexer = Lexer.Cpp;

            textEditor.Styles[Style.Cpp.Identifier].ForeColor = ColourHelper.IntToColour(0x9cdcfe);
            textEditor.Styles[Style.Cpp.Comment].ForeColor = ColourHelper.IntToColour(0x40BF57);
            textEditor.Styles[Style.Cpp.CommentLine].ForeColor = ColourHelper.IntToColour(0x40BF57);
            textEditor.Styles[Style.Cpp.CommentDoc].ForeColor = ColourHelper.IntToColour(0x2FAE35);
            textEditor.Styles[Style.Cpp.Number].ForeColor = ColourHelper.IntToColour(0xb5cea8);
            textEditor.Styles[Style.Cpp.String].ForeColor = ColourHelper.IntToColour(0xc16d3a);
            textEditor.Styles[Style.Cpp.Character].ForeColor = ColourHelper.IntToColour(0xE95454);
            textEditor.Styles[Style.Cpp.Preprocessor].ForeColor = ColourHelper.IntToColour(0x9b9b9b);
            textEditor.Styles[Style.Cpp.Operator].ForeColor = ColourHelper.IntToColour(0xE0E0E0);
            textEditor.Styles[Style.Cpp.Regex].ForeColor = ColourHelper.IntToColour(0xff00ff);
            textEditor.Styles[Style.Cpp.CommentLineDoc].ForeColor = ColourHelper.IntToColour(0x5f8b4e);
            textEditor.Styles[Style.Cpp.Word].ForeColor = ColourHelper.IntToColour(0x48A8EE);
            textEditor.Styles[Style.Cpp.Word2].ForeColor = ColourHelper.IntToColour(0xF98906);
            textEditor.Styles[Style.Cpp.CommentDocKeyword].ForeColor = ColourHelper.IntToColour(0xB3D991);
            textEditor.Styles[Style.Cpp.CommentDocKeywordError].ForeColor = ColourHelper.IntToColour(0xFF0000);
            textEditor.Styles[Style.Cpp.GlobalClass].ForeColor = ColourHelper.IntToColour(0x3bb9b0);


            textEditor.SetKeywords(0, "fn null int string bool float double return if for foreach while do else var");
            textEditor.SetKeywords(1, "");
            textEditor.SetKeywords(3, "Task :");
        }
        private void InitNumberMargin()
        {
            textEditor.Styles[Style.LineNumber].BackColor = ColourHelper.IntToColour(0x313131);
            textEditor.Styles[Style.LineNumber].ForeColor = ColourHelper.IntToColour(0x616161);
            textEditor.Styles[Style.IndentGuide].BackColor = ColourHelper.IntToColour(0x313131);
            textEditor.Styles[Style.IndentGuide].ForeColor = ColourHelper.IntToColour(0x616161);

            var numbers = textEditor.Margins[NUMBER_MARGIN];
            numbers.Width = 30;
            numbers.Type = MarginType.Number;
            numbers.Sensitive = true;
            numbers.Mask = 0;
        }

        private void InitBookmarkMargin()
        {
            var margin = textEditor.Margins[BOOKMARK_MARGIN];
            margin.Width = 20;
            margin.Sensitive = true;
            margin.Type = MarginType.Symbol;
            margin.Mask = (1 << BOOKMARK_MARKER);

            var marker = textEditor.Markers[BOOKMARK_MARKER];
            marker.Symbol = MarkerSymbol.Circle;
            marker.SetBackColor(ColourHelper.IntToColour(0xFF003B));
            marker.SetForeColor(ColourHelper.IntToColour(0x000000));
            marker.SetAlpha(100);
        }

        private void InitCodeFolding()
        {

            textEditor.SetFoldMarginColor(true, ColourHelper.IntToColour(0x313131));
            textEditor.SetFoldMarginHighlightColor(true, ColourHelper.IntToColour(0x313131));

            // Enable code folding
            textEditor.SetProperty("fold", "1");
            textEditor.SetProperty("fold.compact", "1");

            // Configure a margin to display folding symbols
            textEditor.Margins[FOLDING_MARGIN].Type = MarginType.Symbol;
            textEditor.Margins[FOLDING_MARGIN].Mask = Marker.MaskFolders;
            textEditor.Margins[FOLDING_MARGIN].Sensitive = true;
            textEditor.Margins[FOLDING_MARGIN].Width = 20;

            // Set colors for all folding markers
            for (int i = 25; i <= 31; i++)
            {
                textEditor.Markers[i].SetForeColor(ColourHelper.IntToColour(0x313131)); // styles for [+] and [-]
                textEditor.Markers[i].SetBackColor(ColourHelper.IntToColour(0x616161)); // styles for [+] and [-]
            }

            // Configure folding markers with respective symbols
            textEditor.Markers[Marker.Folder].Symbol = CODEFOLDING_CIRCULAR ? MarkerSymbol.CirclePlus : MarkerSymbol.BoxPlus;
            textEditor.Markers[Marker.FolderOpen].Symbol = CODEFOLDING_CIRCULAR ? MarkerSymbol.CircleMinus : MarkerSymbol.BoxMinus;
            textEditor.Markers[Marker.FolderEnd].Symbol = CODEFOLDING_CIRCULAR ? MarkerSymbol.CirclePlusConnected : MarkerSymbol.BoxPlusConnected;
            textEditor.Markers[Marker.FolderMidTail].Symbol = MarkerSymbol.TCorner;
            textEditor.Markers[Marker.FolderOpenMid].Symbol = CODEFOLDING_CIRCULAR ? MarkerSymbol.CircleMinusConnected : MarkerSymbol.BoxMinusConnected;
            textEditor.Markers[Marker.FolderSub].Symbol = MarkerSymbol.VLine;
            textEditor.Markers[Marker.FolderTail].Symbol = MarkerSymbol.LCorner;

            // Enable automatic folding
            textEditor.AutomaticFold = (AutomaticFold.Show | AutomaticFold.Click | AutomaticFold.Change);

        }

        #region Events
        private void TextEditor_MarginClick(object sender, MarginClickEventArgs e)
        {
            if(e.Margin == BOOKMARK_MARGIN)
            {
                const uint mask = (1 << BOOKMARK_MARKER);
                var line = textEditor.Lines[textEditor.LineFromPosition(e.Position)];
                if((line.MarkerGet() & mask) > 0)
                {
                    line.MarkerDelete(BOOKMARK_MARKER);
                }
                else
                {
                    line.MarkerAdd(BOOKMARK_MARKER);
                }
            }
        }

        private void TextEditor_CharAdded(object sender, CharAddedEventArgs e)
        {
            //The '}' char.
            if (e.Char == 125)
            {
                int curLine = textEditor.LineFromPosition(textEditor.CurrentPosition);

                if (textEditor.Lines[curLine].Text.Trim() == "}")
                { //Check whether the bracket is the only thing on the line.. For cases like "if() { }".
                    SetIndent(textEditor, curLine, GetIndent(textEditor, curLine) - 4);
                }
            }
        }

        private void TextEditor_InsertCheck(object sender, InsertCheckEventArgs e)
        {
            if ((e.Text.EndsWith("" + Constants.vbCr) || e.Text.EndsWith("" + Constants.vbLf)))
            {
                int startPos = textEditor.Lines[textEditor.LineFromPosition(textEditor.CurrentPosition)].Position;
                int endPos = e.Position;
                string curLineText = textEditor.GetTextRange(startPos, (endPos - startPos)); //Text until the caret so that the whitespace is always equal in every line.

                Match indent = Regex.Match(curLineText, "^[ \\t]*");
                e.Text = (e.Text + indent.Value);
                if (Regex.IsMatch(curLineText, "{\\s*$"))
                {
                    e.Text = (e.Text + Constants.vbTab);
                }
            }
        }
        #endregion

        #region Indent Functions
        private void SetIndent(ScintillaNET.Scintilla scin, int line, int indent)
        {
            scin.DirectMessage(SCI_SETLINEINDENTATION, new IntPtr(line), new IntPtr(indent));
        }
        private int GetIndent(ScintillaNET.Scintilla scin, int line)
        {
            return (scin.DirectMessage(SCI_GETLINEINDENTATION, new IntPtr(line), (IntPtr)null).ToInt32());
        }
        #endregion

        #region Custom Events
        protected virtual void OnCaretChanged(CaretPositionEventArgs e)
        {
            CaretPositionChanged?.Invoke(this, e);
        }
        #endregion

    }
}
