using IDE.Components;
using IDE.Events;
using IDE.Helper;
using IDE.Preferences;
using IDE.Properties;
using IDE.Views.TextEditorViews;
using Microsoft.VisualBasic;
using ScintillaNET;
using Slang.IDE.Cache.Queries;
using Slang.IDE.Shared.Extensions;
using Slang.IDE.Shared.Helpers;
using System.Text.RegularExpressions;
using WeifenLuo.WinFormsUI.Docking;

namespace IDE.Controls
{
    public partial class SlangTextEditor : DockContent
    {
        #region Constants
        private const int NUMBER_MARGIN = 1;
        private const int BREAKPOINT_MARGIN = 2;
        private const int BREAKPOINT_MARKER = 2;
        private const int BOOKMARK_MARKER = 4;
        private const int BOOKMARK_MARGIN = -2;
        private const int FOLDING_MARGIN = 3;
        private const bool CODEFOLDING_CIRCULAR = true;

        #region Code Indent Handlers
        const int SCI_SETLINEINDENTATION = 2126;
        const int SCI_GETLINEINDENTATION = 2127;
        #endregion

        #region Zoom Lists
        private readonly IReadOnlyDictionary<string, int> _zoomValues = new Dictionary<string, int>() { { "20%", -10 }, { "50%", -6 }, { "100%", 0 }, { "150%", 7 }, { "200%", 14 }, { "250%", 20 } };
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
#pragma warning disable S1104
        public string FilePath = string.Empty;
#pragma warning restore S1104
        #endregion

        #region Events 
        public event EventHandler<CaretPositionEventArgs> CaretPositionChanged;
        public event EventHandler BreakpointAdded;
        public event EventHandler BreakpointDeleted;
        public event EventHandler<BookmarkEventArgs> BookmarkAdded;
        public event EventHandler<BookmarkEventArgs> BookmarkDeleted;
        #endregion

        private readonly FindReplace _findReplace;

#pragma warning disable CS8618
        public SlangTextEditor()
        {
            InitializeComponent();
            AutoScaleMode = AutoScaleMode.Font;
            DockAreas = DockAreas.Document | DockAreas.Float;

            SetupInitSettings();
            InitEvents();

            _findReplace = new FindReplace(textEditor);

            incrementalSearch1.FindReplace = _findReplace;
        }
#pragma warning restore CS8618


        #region Initial Functions

        private void InitEvents()
        {
            textEditor.MarginClick += TextEditor_MarginClick;
            textEditor.InsertCheck += TextEditor_InsertCheck;
            textEditor.CharAdded += TextEditor_CharAdded;
            textEditor.KeyUp += TextEditor_KeyUp;
            textEditor.KeyDown += TextEditor_KeyDown;
            textEditor.KeyPress += TextEditor_KeyPress;
            textEditor.MouseUp += TextEditor_MouseUp;
            textEditor.TextChanged += TextEditor_TextChanged;
            textEditor.ZoomChanged += TextEditor_ZoomChanged;


            CbxAvailableMethods.SelectedIndexChanged += CbxAvailableMethods_SelectedIndexChanged;
        }

        private void SetupInitSettings()
        {
            textEditor.IndentationGuides = IndentView.LookBoth;
            textEditor.Zoom = 0;

            CbxZoom.DataSource = new BindingSource(_zoomValues, null);
            CbxZoom.DisplayMember = "Key";
            CbxZoom.ValueMember = "Value";
            CbxZoom.SelectedValue = 0;
        }

        private void InitColours()
        {
            textEditor.SetSelectionBackColor(true, ColourHelper.IntToColour(0x114D9C));
            textEditor.StyleResetDefault();
            textEditor.Styles[Style.Default].Font = Settings.Default["TextEditorFont"].ToString();
            textEditor.Styles[Style.Default].Size = Settings.Default["TextEditorFontSize"].AsInt();
            textEditor.Styles[Style.Default].Bold = Settings.Default["TextEditorBold"].AsBool();
            textEditor.Styles[Style.Default].Italic = Settings.Default["TextEditorItalic"].AsBool();
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
            textEditor.Styles[Style.Cpp.Word2].ForeColor = ColourHelper.IntToColour(0xfff5ac);
            textEditor.Styles[Style.Cpp.CommentDocKeyword].ForeColor = ColourHelper.IntToColour(0xB3D991);
            textEditor.Styles[Style.Cpp.CommentDocKeywordError].ForeColor = ColourHelper.IntToColour(0xFF0000);
            textEditor.Styles[Style.Cpp.GlobalClass].ForeColor = ColourHelper.IntToColour(0x3bb9b0);


            textEditor.SetKeywords(0, string.Join(" ", SystemPreferences.Keywords));
            textEditor.SetKeywords(1, string.Join(" ", SystemPreferences.UserDefineFunctions.Select(x => x.Name.Substring(0, x.Name.IndexOf('(')))) + " " + string.Join(" ", SystemPreferences.SystemFunctions));
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
            var margin = textEditor.Margins[BREAKPOINT_MARGIN];
            margin.Width = 20;
            margin.Sensitive = true;
            margin.Type = MarginType.Symbol;
            margin.Mask = (1 << BREAKPOINT_MARKER);

            var marker = textEditor.Markers[BREAKPOINT_MARKER];
            marker.Symbol = MarkerSymbol.Circle;
            marker.SetBackColor(ColourHelper.IntToColour(0xFF003B));
            marker.SetForeColor(ColourHelper.IntToColour(0x000000));
            marker.SetAlpha(100);

            var bookmarkMargin = textEditor.Margins[BOOKMARK_MARGIN];
            bookmarkMargin.Width = 20;
            bookmarkMargin.Sensitive = true;
            bookmarkMargin.Type = MarginType.Symbol;
            bookmarkMargin.Mask = (1 << BOOKMARK_MARKER);


            var bookmarkMarker = textEditor.Markers[BOOKMARK_MARKER];
            bookmarkMarker.Symbol = MarkerSymbol.Bookmark;
            bookmarkMarker.SetBackColor(ColourHelper.IntToColour(0x1f88d9));
            bookmarkMarker.SetForeColor(ColourHelper.IntToColour(0x000000));
            bookmarkMarker.SetAlpha(100);
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
        #endregion

        #region Events
        private void TextEditor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 32)
            {
                e.Handled = true;
                return;
            }

            // If you stored the results in a list, you can now use them as needed.
            // For example, display them in a message box or update a UI element.
            CbxAvailableMethods.DataSource = SystemPreferences.UserDefineFunctions;
            CbxAvailableMethods.DisplayMember = "Name";
            CbxAvailableMethods.ValueMember = "Column";
            CbxAvailableMethods.SelectedIndexChanged += CbxAvailableMethods_SelectedIndexChanged;
            InitSyntaxHighlitning();
            textEditor.Update();
        }

        private void TextEditor_KeyDown(object sender, KeyEventArgs e)
        {
            // Go To Line
            if (e.KeyCode == Keys.Control | e.KeyCode == Keys.G)
            {
                using var frmGoToLine = new FrmGoToLine(textEditor.LineFromPosition(textEditor.CurrentPosition), textEditor.Lines.Count);
                var dr = frmGoToLine.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    textEditor.GotoPosition(textEditor.Lines[frmGoToLine.ReturnedLine].Position);
                }
            }
        }

        private void SlangTextEditor_Load(object sender, EventArgs e)
        {
            InitColours();
            InitSyntaxHighlitning();
            InitNumberMargin();
            InitBookmarkMargin();
            InitCodeFolding();
        }

        private void TextEditor_MarginClick(object sender, MarginClickEventArgs e)
        {
            if (Features.BreakpointEnable)
            {
                if (e.Margin == BREAKPOINT_MARGIN)
                {
                    const uint mask = (1 << BREAKPOINT_MARKER);
                    var line = textEditor.Lines[textEditor.LineFromPosition(e.Position)];
                    if ((line.MarkerGet() & mask) > 0)
                    {
                        line.MarkerDelete(BREAKPOINT_MARKER);

                        var breakpoint = Sessions.Breakpoints.First(x => x.FilePath == Sessions.SlangProject.Files.First(x => x.Name == this.Text).FilePath
                        && x.Line == textEditor.LineFromPosition(e.Position));
                        Sessions.Breakpoints.Remove(breakpoint);

                        OnBreakpointDeleted(new EventArgs());
                    }
                    else
                    {
                        line.MarkerAdd(BREAKPOINT_MARKER);
                        Sessions.Breakpoints.Add(new Slang.IDE.Shared.IDE.Breakpoint
                        {
                            Name = $"Breakpoint {Sessions.Breakpoints.Count + 1}",
                            FilePath = Sessions.SlangProject.Files.First(x => x.Name == this.Text).FilePath,
                            Line = textEditor.LineFromPosition(e.Position)

                        });

                        OnBreakpointAdded(new EventArgs());
                    }
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
                e.Text += indent.Value;
                if (Regex.IsMatch(curLineText, "{\\s*$"))
                {
                    e.Text += Constants.vbTab;
                }
            }
        }

        private void TextEditor_ZoomChanged(object sender, EventArgs e)
        {
            CbxZoom.Text = $"{Functions.Map(textEditor.Zoom, -10, 20, 20, 250)} %";
        }

        private void CbxAvailableMethods_SelectedIndexChanged(object sender, EventArgs e)
        {
            textEditor.GotoPosition(SystemPreferences.UserDefineFunctions[CbxAvailableMethods.SelectedIndex].Column);
            textEditor.Focus();
        }

        private void TextEditor_TextChanged(object sender, EventArgs e)
        {
            // Get the entire text from the RichTextBox
            CbxAvailableMethods.SelectedIndexChanged -= CbxAvailableMethods_SelectedIndexChanged;
            SystemPreferences.UserDefineFunctions.Clear();
            CbxAvailableMethods.DataSource = null;
            CbxAvailableMethods.Items.Clear();

            string fullText = textEditor.Text;

            int startIndex = 0;

            // Loop to find all occurrences of "fn" and "{"
            while (startIndex < fullText.Length)
            {
                // Find the starting position of "fn" after the previous startIndex
                int fnIndex = fullText.IndexOf("fn", startIndex);
                if (fnIndex == -1)
                {
                    // "fn" not found, break out of the loop
                    break;
                }

                // Find the position of "{" starting from the position of "fn"
                int openBraceIndex = fullText.IndexOf("{", fnIndex);
                if (openBraceIndex == -1)
                {
                    // "{" not found, break out of the loop
                    break;
                }

                // Extract the text between "fn" and "{"
                string result = fullText.Substring(fnIndex + 2, openBraceIndex - fnIndex - 2).Trim();

                // Πάρε το Result και βρες τα Parameters
                //var parameters = "a:int,b:int";
                //var split, parameters.Split();



                SystemPreferences.UserDefineFunctions.Add(new UserDefineFunction { Name = result, Column = fnIndex + 2 });
                // Update your UI or perform any other action with the extracted text
                // For example, display the result in a label or add it to the list.

                // Move the startIndex to the position after the current "{" to search for the next occurrence
                startIndex = openBraceIndex + 1;
            }

            // If you stored the results in a list, you can now use them as needed.
            // For example, display them in a message box or update a UI element.
            CbxAvailableMethods.DataSource = SystemPreferences.UserDefineFunctions;
            CbxAvailableMethods.DisplayMember = "Name";
            CbxAvailableMethods.ValueMember = "Column";
            CbxAvailableMethods.SelectedIndexChanged += CbxAvailableMethods_SelectedIndexChanged;
            InitSyntaxHighlitning();
            textEditor.Update();
        }

        private void TextEditor_MouseUp(object sender, MouseEventArgs e)
        {
            OnCaretChanged(new CaretPositionEventArgs { Line = textEditor.CurrentLine + 1, Column = textEditor.GetColumn(textEditor.CurrentPosition) + 1, Position = textEditor.CurrentPosition + 1 });
        }

        private void TextEditor_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter
                || e.KeyCode == Keys.Up
                || e.KeyCode == Keys.Down
                || e.KeyCode == Keys.Right
                || e.KeyCode == Keys.Left)
            {
                OnCaretChanged(new CaretPositionEventArgs { Line = textEditor.CurrentLine + 1, Column = textEditor.GetColumn(textEditor.CurrentPosition) + 1, Position = textEditor.CurrentPosition + 1 });
            }
        }

        private void SlangTextEditor_Shown(object sender, EventArgs e)
        {
            textEditor.Focus();

            // Load Bookmarks
            LoadBookmarks();
        }

        private void CbxZoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            textEditor.Zoom = CbxZoom.SelectedValue.AsInt();
        }

        private void CbxZoom_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                ComboBoxTextChanged();
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

        protected virtual void OnBreakpointAdded(EventArgs e)
        {
            BreakpointAdded?.Invoke(this, e);
        }

        protected virtual void OnBreakpointDeleted(EventArgs e)
        {
            BreakpointDeleted?.Invoke(this, e);
        }

        protected virtual void OnBookmarkAdded(BookmarkEventArgs e)
        {
            BookmarkAdded?.Invoke(this, e);
        }

        protected virtual void OnBookmarkDeleted(BookmarkEventArgs e)
        {
            BookmarkDeleted?.Invoke(this, e);
        }
        #endregion

        #region Helper Functions 

        private void ComboBoxTextChanged()
        {
            if (CbxZoom.Text.Length < 2)
            {
                return;
            }

            if (!int.TryParse(CbxZoom.Text, out var result))
            {
                MessageBox.Show("The value that you typed cannot represent as number.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CbxZoom.Text = "100%";
                textEditor.Zoom = 0;
                return;
            }

            if (result < 20 || result > 250)
            {
                MessageBox.Show("The value that you typed is not valid. Limits are 20% up to 250%.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CbxZoom.Text = "100%";
                textEditor.Zoom = 0;
                return;
            }

            var zoomValue = Functions.Map(result, 20, 250, -10, 20);
            textEditor.Zoom = zoomValue;
            CbxZoom.Text = $"{result}%";
        }

        public void ReloadFonts()
        {
            InitColours();
            InitSyntaxHighlitning();
            InitNumberMargin();
            InitBookmarkMargin();
            InitCodeFolding();
        }

        public void DeleteAllBookmarks()
        {
            textEditor.MarkerDeleteAll(BOOKMARK_MARKER);
        }

        private void LoadBookmarks()
        {
            var bookmarks = BookmarkQueriesCollection.FetchAll(FilePath);

            foreach (var bookmark in bookmarks)
            {
                var line = textEditor.Lines[bookmark.Line - 1];
                line.MarkerAdd(BOOKMARK_MARKER);
            }
        }

        public void ToggleBookmark()
        {
            if (Features.BookmarkEnable)
            {
                const uint mask = (1 << BOOKMARK_MARKER);
                var line = textEditor.Lines[textEditor.LineFromPosition(textEditor.CurrentPosition)];
                if ((line.MarkerGet() & mask) > 0)
                {
                    line.MarkerDelete(BOOKMARK_MARKER);
                    OnBookmarkDeleted(new BookmarkEventArgs(Sessions.SlangProject.Files.First(x => x.Name == this.Text && x.FilePath == FilePath).Id.ToString(), FilePath, textEditor.CurrentLine + 1));
                }
                else
                {
                    line.MarkerAdd(BOOKMARK_MARKER);
                    OnBookmarkAdded(new BookmarkEventArgs(Sessions.SlangProject.Files.First(x => x.Name == this.Text && x.FilePath == FilePath).Id.ToString(), FilePath, textEditor.CurrentLine + 1));
                } 
            }
        }

        public void ShowQuickFind()
        {
            _findReplace.ShowIncrementalSearch();
        }

        public void ShowAdvancedFind()
        {
            _findReplace.ShowFind();
        }
        #endregion
    }
}
