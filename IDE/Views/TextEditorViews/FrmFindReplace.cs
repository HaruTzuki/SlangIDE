using IDE.Components;
using ScintillaNET;
using System.Text.RegularExpressions;
using CharacterRange = IDE.Helper.CharacterRange;

namespace IDE.Views.TextEditorViews
{
    public partial class FrmFindReplace : Form
    {
        #region Fields
        private bool _autoPosition;
        private BindingSource _bindingSourceFind = new BindingSource();
        private BindingSource _bindingSourceReplace = new BindingSource();
        private List<string> _mruFind;
        private int _mruMaxCount = 10;
        private List<string> _mruReplace;
        private Scintilla _textEditor;
        private CharacterRange _searchRange;
        #endregion

        public event KeyPressedHandler KeyPressed;

        public delegate void KeyPressedHandler(object sender, KeyEventArgs e);

        public FrmFindReplace()
        {
            InitializeComponent();
            _autoPosition = true;
            _mruFind = new List<string>();
            _mruReplace = new List<string>();
            _bindingSourceFind.DataSource = _mruFind;
            _bindingSourceReplace.DataSource = _mruReplace;
        }

        #region Properties

        /// <summary>
        /// Gets or sets whether the dialog should automatically move away from the current
        /// selection to prevent obscuring it.
        /// </summary>
        /// <returns>true to automatically move away from the current selection; otherwise, false.</returns>
        public bool AutoPosition
        {
            get
            {
                return _autoPosition;
            }
            set
            {
                _autoPosition = value;
            }
        }

        public List<string> MruFind
        {
            get
            {
                return _mruFind;
            }
            set
            {
                _mruFind = value;
                _bindingSourceFind.DataSource = _mruFind;
            }
        }

        public int MruMaxCount
        {
            get { return _mruMaxCount; }
            set { _mruMaxCount = value; }
        }

        public List<string> MruReplace
        {
            get
            {
                return _mruReplace;
            }
            set
            {
                _mruReplace = value;
                _bindingSourceReplace.DataSource = _mruReplace;
            }
        }

        public Scintilla TextEditor
        {
            get
            {
                return _textEditor;
            }
            set
            {
                _textEditor = value;
            }
        }

        public FindReplace FindReplace { get; set; }


        #endregion Properties

        #region Form Event Handlers
        private void FrmFindReplace_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void FrmFindReplace_Activated(object sender, EventArgs e)
        {
            Opacity = 1.0;
        }

        private void FrmFindReplace_Deactivate(object sender, EventArgs e)
        {
            Opacity = 0.6;
        }
        #endregion

        #region Event Handlers
        private void BtnClearF_Click(object sender, EventArgs e)
        {
            _textEditor.MarkerDeleteAll(FindReplace.Marker.Index);
            FindReplace.ClearAllHighlights();
        }

        private void BtnFindAllF_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtFindF.Text))
            {
                return;
            }

            AddFindMru();

            LblStatus.Text = string.Empty;
            BtnClearF_Click(null, null);
            int foundCount = 0;

            #region RegEx

            if (RbtnRegexF.Checked)
            {
                Regex rr = null;
                try
                {
                    rr = new Regex(TxtFindF.Text, GetRegexOptions());
                }
                catch (ArgumentException ex)
                {
                    LblStatus.Text = $"Error in Regular Expression: {ex.Message}";
                    return;
                }

                if (ChkSearchSelectionF.Checked)
                {
                    if (_searchRange.cpMin == _searchRange.cpMax)
                    {
                        _searchRange = new CharacterRange(_textEditor.Selections[0].Start, _textEditor.Selections[0].End);
                    }

                    foundCount = FindReplace.FindAll(_searchRange, rr, ChkMarkLineF.Checked, ChkHighlightMatchesF.Checked).Count;
                }
                else
                {
                    _searchRange = new CharacterRange();
                    foundCount = FindReplace.FindAll(rr, ChkMarkLineF.Checked, ChkHighlightMatchesF.Checked).Count;
                }

            }


            #endregion

            #region Non-RegEx
            if (!RbtnRegexF.Checked)
            {
                if (ChkSearchSelectionF.Checked)
                {
                    if (_searchRange.cpMin == _searchRange.cpMax)
                        _searchRange = new CharacterRange(_textEditor.Selections[0].Start, _textEditor.Selections[0].End);

                    string textToFind = RbtnExtendedF.Checked ? FindReplace.Transform(TxtFindF.Text) : TxtFindF.Text;
                    foundCount = FindReplace.FindAll(_searchRange, textToFind, GetSearchFlags(), ChkMarkLineF.Checked, ChkHighlightMatchesF.Checked).Count;
                }
                else
                {
                    _searchRange = new CharacterRange();
                    string textToFind = RbtnExtendedF.Checked ? FindReplace.Transform(TxtFindF.Text) : TxtFindF.Text;
                    foundCount = FindReplace.FindAll(textToFind, GetSearchFlags(), ChkMarkLineF.Checked, ChkHighlightMatchesF.Checked).Count;
                }
            }
            #endregion

            LblStatus.Text = $"Total found: {foundCount}";
        }

        private void BtnFindNextF_Click(object sender, EventArgs e)
        {
            FindNext();
        }

        private void BtnFindPreviousF_Click(object sender, EventArgs e)
        {
            FindPrevious();
        }

        private void BtnReplaceAll_Click(object sender, EventArgs e)
        {
            if (TxtFindR.Text == string.Empty)
                return;

            AddReplaceMru();
            LblStatus.Text = string.Empty;
            int foundCount = 0;

            #region RegEx

            if (RbtnRegexR.Checked)
            {
                Regex rr = null;
                try
                {
                    rr = new Regex(TxtFindR.Text, GetRegexOptions());
                }
                catch (ArgumentException ex)
                {
                    LblStatus.Text = $"Error in Regular Expression: {ex.Message}";
                    return;
                }

                if (ChkSearchSelectionR.Checked)
                {
                    if (_searchRange.cpMin == _searchRange.cpMax)
                    {
                        _searchRange = new CharacterRange(_textEditor.Selections[0].Start, _textEditor.Selections[0].End);
                    }

                    foundCount = FindReplace.ReplaceAll(_searchRange, rr, TxtReplaceR.Text, false, false);
                }
                else
                {
                    _searchRange = new CharacterRange();
                    foundCount = FindReplace.ReplaceAll(rr, TxtReplaceR.Text, false, false);
                }
            }

            #endregion

            #region Non-RegEx

            if (!RbtnRegexR.Checked)
            {
                if (ChkSearchSelectionR.Checked)
                {
                    if (_searchRange.cpMin == _searchRange.cpMax)
                        _searchRange = new CharacterRange(_textEditor.Selections[0].Start, _textEditor.Selections[0].End);

                    string textToFind = RbtnExtendedR.Checked ? FindReplace.Transform(TxtFindR.Text) : TxtFindR.Text;
                    string textToReplace = RbtnExtendedR.Checked ? FindReplace.Transform(TxtReplaceR.Text) : TxtReplaceR.Text;
                    foundCount = FindReplace.ReplaceAll(_searchRange, textToFind, textToReplace, GetSearchFlags(), false, false);
                }
                else
                {
                    _searchRange = new CharacterRange();
                    string textToFind = RbtnExtendedR.Checked ? FindReplace.Transform(TxtFindR.Text) : TxtFindR.Text;
                    string textToReplace = RbtnExtendedR.Checked ? FindReplace.Transform(TxtReplaceR.Text) : TxtReplaceR.Text;
                    foundCount = FindReplace.ReplaceAll(textToFind, textToReplace, GetSearchFlags(), false, false);
                }
            }

            #endregion

            LblStatus.Text = "Total Replaced: " + foundCount.ToString();

        }

        private void BtnReplaceNext_Click(object sender, EventArgs e)
        {
            ReplaceNext();
        }

        private void BtnReplacePrevious_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtFindR.Text))
                return;

            AddReplaceMru();
            LblStatus.Text = string.Empty;

            CharacterRange nextRange;
            try
            {
                nextRange = ReplaceNext(true);
            }
            catch (ArgumentException ex)
            {
                LblStatus.Text = "Error in Regular Expression: " + ex.Message;
                return;
            }

            if (nextRange.cpMin == nextRange.cpMax)
            {
                LblStatus.Text = "Match could not be found";
            }
            else
            {
                if (nextRange.cpMin > _textEditor.AnchorPosition)
                {
                    if (ChkSearchSelectionR.Checked)
                        LblStatus.Text = "Search match wrapped to the beginning of the selection";
                    else
                        LblStatus.Text = "Search match wrapped to the beginning of the document";
                }

                _textEditor.SetSel(nextRange.cpMin, nextRange.cpMax);
                MoveFormAwayFromSelection();
            }
        }

        private void ChkEcmaScript_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                ChkExplicitCaptureF.Checked = false;
                ChkExplicitCaptureR.Checked = false;
                ChkExplicitCaptureF.Enabled = false;
                ChkExplicitCaptureR.Enabled = false;
                ChkIgnorePatternWhitespaceF.Checked = false;
                ChkIgnorePatternWhitespaceR.Checked = false;
                ChkIgnorePatternWhitespaceF.Enabled = false;
                ChkIgnorePatternWhitespaceR.Enabled = false;
                ChkRightToLeftF.Checked = false;
                ChkRightToLeftR.Checked = false;
                ChkRightToLeftF.Enabled = false;
                ChkRightToLeftR.Enabled = false;
                ChkSinglelineF.Checked = false;
                ChkSinglelineR.Checked = false;
                ChkSinglelineF.Enabled = false;
                ChkSinglelineR.Enabled = false;
            }
            else
            {
                ChkExplicitCaptureF.Enabled = true;
                ChkIgnorePatternWhitespaceF.Enabled = true;
                ChkRightToLeftF.Enabled = true;
                ChkSinglelineF.Enabled = true;
                ChkExplicitCaptureR.Enabled = true;
                ChkIgnorePatternWhitespaceR.Enabled = true;
                ChkRightToLeftR.Enabled = true;
                ChkSinglelineR.Enabled = true;
            }
        }

        private void cmdRecentFindF_Click(object sender, EventArgs e)
        {
            mnuRecentFindF.Items.Clear();
            foreach (var item in MruFind)
            {
                ToolStripItem newItem = mnuRecentFindF.Items.Add(item);
                newItem.Tag = item;
            }
            mnuRecentFindF.Items.Add("-");
            mnuRecentFindF.Items.Add("Clear History");
            mnuRecentFindF.Show(cmdRecentFindF.PointToScreen(cmdRecentFindF.ClientRectangle.Location));
        }

        private void cmdRecentFindR_Click(object sender, EventArgs e)
        {
            mnuRecentFindR.Items.Clear();
            foreach (var item in MruFind)
            {
                ToolStripItem newItem = mnuRecentFindR.Items.Add(item);
                newItem.Tag = item;
            }
            mnuRecentFindR.Items.Add("-");
            mnuRecentFindR.Items.Add("Clear History");
            mnuRecentFindR.Show(cmdRecentFindR.PointToScreen(cmdRecentFindR.ClientRectangle.Location));
        }

        private void cmdRecentReplace_Click(object sender, EventArgs e)
        {
            mnuRecentReplace.Items.Clear();
            foreach (var item in MruReplace)
            {
                ToolStripItem newItem = mnuRecentReplace.Items.Add(item);
                newItem.Tag = item;
            }
            mnuRecentReplace.Items.Add("-");
            mnuRecentReplace.Items.Add("Clear History");
            mnuRecentReplace.Show(cmdRecentReplace.PointToScreen(cmdRecentReplace.ClientRectangle.Location));
        }

        private void cmdExtCharAndRegExFindF_Click(object sender, EventArgs e)
        {
            if (RbtnExtendedF.Checked)
            {
                mnuExtendedCharFindF.Show(cmdExtCharAndRegExFindF.PointToScreen(cmdExtCharAndRegExFindF.ClientRectangle.Location));
            }
            else if (RbtnRegexF.Checked)
            {
                mnuRegExCharFindF.Show(cmdExtCharAndRegExFindF.PointToScreen(cmdExtCharAndRegExFindF.ClientRectangle.Location));
            }
        }

        private void cmdExtCharAndRegExFindR_Click(object sender, EventArgs e)
        {
            if (RbtnExtendedR.Checked)
            {
                mnuExtendedCharFindR.Show(cmdExtCharAndRegExFindR.PointToScreen(cmdExtCharAndRegExFindR.ClientRectangle.Location));
            }
            else if (RbtnRegexR.Checked)
            {
                mnuRegExCharFindR.Show(cmdExtCharAndRegExFindR.PointToScreen(cmdExtCharAndRegExFindR.ClientRectangle.Location));
            }
        }

        private void cmdExtCharAndRegExReplace_Click(object sender, EventArgs e)
        {
            if (RbtnExtendedR.Checked)
            {
                mnuExtendedCharReplace.Show(cmdExtCharAndRegExReplace.PointToScreen(cmdExtCharAndRegExReplace.ClientRectangle.Location));
            }
            else if (RbtnRegexR.Checked)
            {
                mnuRegExCharReplace.Show(cmdExtCharAndRegExReplace.PointToScreen(cmdExtCharAndRegExReplace.ClientRectangle.Location));
            }
        }

        private void RbtnStandardR_CheckedChanged(object sender, EventArgs e)
        {
            if (RbtnStandardF.Checked)
                PnlStandardOptionsF.BringToFront();
            else
                PnlRegexpOptionsF.BringToFront();

            cmdExtCharAndRegExFindF.Enabled = !RbtnStandardF.Checked;
        }

        private void RbtnStandardF_CheckedChanged(object sender, EventArgs e)
        {
            if (RbtnStandardR.Checked)
                PnlStandardOptionsR.BringToFront();
            else
                PnlRegexpOptionsR.BringToFront();

            cmdExtCharAndRegExFindR.Enabled = !RbtnStandardR.Checked;
            cmdExtCharAndRegExReplace.Enabled = !RbtnStandardR.Checked;
        }

        private void TabAll_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabAll.SelectedTab == TpgFind)
            {
                TxtFindF.Text = TxtFindR.Text;

                RbtnStandardF.Checked = RbtnStandardR.Checked;
                RbtnExtendedF.Checked = RbtnExtendedR.Checked;
                RbtnRegexF.Checked = RbtnRegexR.Checked;

                ChkWrapF.Checked = ChkWrapR.Checked;
                ChkSearchSelectionF.Checked = ChkSearchSelectionR.Checked;

                ChkMatchCaseF.Checked = ChkMatchCaseR.Checked;
                ChkWholeWordF.Checked = ChkWholeWordR.Checked;
                ChkWordStartF.Checked = ChkWordStartR.Checked;

                ChkCompiledF.Checked = ChkCompiledR.Checked;
                ChkCulturalInvariantF.Checked = ChkCulturalInvariantR.Checked;
                ChkEcmaScriptF.Checked = ChkEcmaScriptR.Checked;
                ChkExplicitCaptureF.Checked = ChkExplicitCaptureR.Checked;
                ChkIgnoreCaseF.Checked = ChkIgnoreCaseR.Checked;
                ChkIgnorePatternWhitespaceF.Checked = ChkIgnorePatternWhitespaceR.Checked;
                ChkMultilineF.Checked = ChkMultilineR.Checked;
                ChkRightToLeftF.Checked = ChkRightToLeftR.Checked;
                ChkSinglelineF.Checked = ChkSinglelineR.Checked;

                AcceptButton = BtnFindNextF;
            }
            else
            {
                TxtFindR.Text = TxtFindF.Text;

                RbtnStandardR.Checked = RbtnStandardF.Checked;
                RbtnExtendedR.Checked = RbtnExtendedF.Checked;
                RbtnRegexR.Checked = RbtnRegexF.Checked;

                ChkWrapR.Checked = ChkWrapF.Checked;
                ChkSearchSelectionR.Checked = ChkSearchSelectionF.Checked;

                ChkMatchCaseR.Checked = ChkMatchCaseF.Checked;
                ChkWholeWordR.Checked = ChkWholeWordF.Checked;
                ChkWordStartR.Checked = ChkWordStartF.Checked;

                ChkCompiledR.Checked = ChkCompiledF.Checked;
                ChkCulturalInvariantR.Checked = ChkCulturalInvariantF.Checked;
                ChkEcmaScriptR.Checked = ChkEcmaScriptF.Checked;
                ChkExplicitCaptureR.Checked = ChkExplicitCaptureF.Checked;
                ChkIgnoreCaseR.Checked = ChkIgnoreCaseF.Checked;
                ChkIgnorePatternWhitespaceR.Checked = ChkIgnorePatternWhitespaceF.Checked;
                ChkMultilineR.Checked = ChkMultilineF.Checked;
                ChkRightToLeftR.Checked = ChkRightToLeftF.Checked;
                ChkSinglelineR.Checked = ChkSinglelineF.Checked;

                AcceptButton = BtnReplaceNext;
            }
        }

        private void mnuExtendedCharFindF_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //Insert the string value held in the menu items Tag field (\t, \n, etc.)
            TxtFindF.SelectedText = e.ClickedItem.Tag.ToString();
        }

        private void mnuRecentFindF_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //Insert the string value held in the menu items Tag field (\t, \n, etc.)
            if (e.ClickedItem.Text == "Clear History")
            {
                MruFind.Clear();
            }
            else
            {
                TxtFindF.Text = e.ClickedItem.Tag.ToString();
            }
        }

        private void mnuRecentFindR_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //Insert the string value held in the menu items Tag field (\t, \n, etc.)
            if (e.ClickedItem.Text == "Clear History")
            {
                MruFind.Clear();
            }
            else
            {
                TxtFindR.Text = e.ClickedItem.Tag.ToString();
            }
        }

        private void mnuRecentReplace_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //Insert the string value held in the menu items Tag field (\t, \n, etc.)
            if (e.ClickedItem.Text == "Clear History")
            {
                MruReplace.Clear();
            }
            else
            {
                TxtReplaceR.Text = e.ClickedItem.Tag.ToString();
            }
        }

        private void mnuExtendedCharFindR_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //Insert the string value held in the menu items Tag field (\t, \n, etc.)
            TxtFindR.SelectedText = e.ClickedItem.Tag.ToString();
        }

        private void mnuExtendedCharReplace_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //Insert the string value held in the menu items Tag field (\t, \n, etc.)
            TxtReplaceR.SelectedText = e.ClickedItem.Tag.ToString();
        }
        #endregion

        #region Methods
        public virtual void MoveFormAwayFromSelection()
        {
            if (!Visible)
                return;

            if (!AutoPosition)
                return;

            int pos = TextEditor.CurrentPosition;
            int x = TextEditor.PointXFromPosition(pos);
            int y = TextEditor.PointYFromPosition(pos);

            Point cursorPoint = TextEditor.PointToScreen(new Point(x, y));

            Rectangle r = new Rectangle(Location, Size);
            if (r.Contains(cursorPoint))
            {
                Point newLocation;
                if (cursorPoint.Y < (Screen.PrimaryScreen.Bounds.Height / 2))
                {
                    //TODO - replace lineheight with ScintillaNET command, when added
                    int SCI_TEXTHEIGHT = 2279;
                    int lineHeight = TextEditor.DirectMessage(SCI_TEXTHEIGHT, IntPtr.Zero, IntPtr.Zero).ToInt32();
                    // int lineHeight = Scintilla.Lines[Scintilla.LineFromPosition(pos)].Height;

                    // Top half of the screen
                    newLocation = TextEditor.PointToClient(
                        new Point(Location.X, cursorPoint.Y + lineHeight * 2));
                }
                else
                {
                    //TODO - replace lineheight with ScintillaNET command, when added
                    int SCI_TEXTHEIGHT = 2279;
                    int lineHeight = TextEditor.DirectMessage(SCI_TEXTHEIGHT, IntPtr.Zero, IntPtr.Zero).ToInt32();
                    // int lineHeight = Scintilla.Lines[Scintilla.LineFromPosition(pos)].Height;

                    // Bottom half of the screen
                    newLocation = TextEditor.PointToClient(
                        new Point(Location.X, cursorPoint.Y - Height - (lineHeight * 2)));
                }
                newLocation = TextEditor.PointToScreen(newLocation);
                Location = newLocation;
            }
        }

        public void ReplaceNext()
        {
            if (string.IsNullOrEmpty(TxtFindR.Text))
                return;

            AddReplaceMru();
            LblStatus.Text = string.Empty;

            CharacterRange nextRange;
            try
            {
                nextRange = ReplaceNext(false);
            }
            catch (ArgumentException ex)
            {
                LblStatus.Text = "Error in Regular Expression: " + ex.Message;
                return;
            }

            if (nextRange.cpMin == nextRange.cpMax)
            {
                LblStatus.Text = "Match could not be found";
            }
            else
            {
                if (nextRange.cpMin < TextEditor.AnchorPosition)
                {
                    if (ChkSearchSelectionR.Checked)
                        LblStatus.Text = "Search match wrapped to the beginning of the selection";
                    else
                        LblStatus.Text = "Search match wrapped to the beginning of the document";
                }

                TextEditor.SetSel(nextRange.cpMin, nextRange.cpMax);
                MoveFormAwayFromSelection();
            }
        }

        private CharacterRange FindNextR(bool searchUp, ref Regex rr)
        {
            CharacterRange foundRange;

            if (RbtnRegexR.Checked)
            {
                if (rr == null)
                    rr = new Regex(TxtFindR.Text, GetRegexOptions());

                if (ChkSearchSelectionR.Checked)
                {
                    if (_searchRange.cpMin == _searchRange.cpMax)
                        _searchRange = new CharacterRange(_textEditor.Selections[0].Start, _textEditor.Selections[0].End);

                    if (searchUp)
                        foundRange = FindReplace.FindPrevious(rr, ChkWrapR.Checked, _searchRange);
                    else
                        foundRange = FindReplace.FindNext(rr, ChkWrapR.Checked, _searchRange);
                }
                else
                {
                    _searchRange = new CharacterRange();
                    if (searchUp)
                        foundRange = FindReplace.FindPrevious(rr, ChkWrapR.Checked);
                    else
                        foundRange = FindReplace.FindNext(rr, ChkWrapR.Checked);
                }
            }
            else
            {
                if (ChkSearchSelectionF.Checked)
                {
                    if (_searchRange.cpMin == _searchRange.cpMax)
                        _searchRange = new CharacterRange(_textEditor.Selections[0].Start, _textEditor.Selections[0].End);

                    if (searchUp)
                    {
                        string textToFind = RbtnExtendedR.Checked ? FindReplace.Transform(TxtFindR.Text) : TxtFindR.Text;
                        foundRange = FindReplace.FindPrevious(textToFind, ChkWrapR.Checked, GetSearchFlags(), _searchRange);
                    }
                    else
                    {
                        string textToFind = RbtnExtendedR.Checked ? FindReplace.Transform(TxtFindR.Text) : TxtFindR.Text;
                        foundRange = FindReplace.FindNext(textToFind, ChkWrapR.Checked, GetSearchFlags(), _searchRange);
                    }
                }
                else
                {
                    _searchRange = new CharacterRange();
                    if (searchUp)
                    {
                        string textToFind = RbtnExtendedR.Checked ? FindReplace.Transform(TxtFindR.Text) : TxtFindR.Text;
                        foundRange = FindReplace.FindPrevious(textToFind, ChkWrapR.Checked, GetSearchFlags());
                    }
                    else
                    {
                        string textToFind = RbtnExtendedR.Checked ? FindReplace.Transform(TxtFindR.Text) : TxtFindR.Text;
                        foundRange = FindReplace.FindNext(textToFind, ChkWrapR.Checked, GetSearchFlags());
                    }
                }
            }
            return foundRange;
        }

        private CharacterRange ReplaceNext(bool searchUp)
        {
            Regex rr = null;
            CharacterRange selRange = new CharacterRange(_textEditor.Selections[0].Start, _textEditor.Selections[0].End);

            //	We only do the actual replacement if the current selection exactly
            //	matches the find.
            if (selRange.cpMax - selRange.cpMin > 0)
            {
                if (RbtnRegexR.Checked)
                {
                    rr = new Regex(TxtFindR.Text, GetRegexOptions());
                    string selRangeText = TextEditor.GetTextRange(selRange.cpMin, selRange.cpMax - selRange.cpMin + 1);

                    if (selRange.Equals(FindReplace.Find(selRange, rr, false)))
                    {
                        //	If searching up we do the replacement using the range object.
                        //	Otherwise we use the selection object. The reason being if
                        //	we use the range the caret is positioned before the replaced
                        //	text. Conversely if we use the selection object the caret will
                        //	be positioned after the replaced text. This is very important
                        //	becuase we don't want the new text to be potentially matched
                        //	in the next search.
                        if (searchUp)
                        {
                            _textEditor.SelectionStart = selRange.cpMin;
                            _textEditor.SelectionEnd = selRange.cpMax;
                            _textEditor.ReplaceSelection(rr.Replace(selRangeText, TxtReplaceR.Text));
                            _textEditor.GotoPosition(selRange.cpMin);
                        }
                        else
                            TextEditor.ReplaceSelection(rr.Replace(selRangeText, TxtReplaceR.Text));
                    }
                }
                else
                {
                    string textToFind = RbtnExtendedR.Checked ? FindReplace.Transform(TxtFindR.Text) : TxtFindR.Text;
                    if (selRange.Equals(FindReplace.Find(selRange, textToFind, false)))
                    {
                        //	If searching up we do the replacement using the range object.
                        //	Otherwise we use the selection object. The reason being if
                        //	we use the range the caret is positioned before the replaced
                        //	text. Conversely if we use the selection object the caret will
                        //	be positioned after the replaced text. This is very important
                        //	becuase we don't want the new text to be potentially matched
                        //	in the next search.
                        if (searchUp)
                        {
                            string textToReplace = RbtnExtendedR.Checked ? FindReplace.Transform(TxtReplaceR.Text) : TxtReplaceR.Text;
                            _textEditor.SelectionStart = selRange.cpMin;
                            _textEditor.SelectionEnd = selRange.cpMax;
                            _textEditor.ReplaceSelection(textToReplace);

                            _textEditor.GotoPosition(selRange.cpMin);
                        }
                        else
                        {
                            string textToReplace = RbtnExtendedR.Checked ? FindReplace.Transform(TxtReplaceR.Text) : TxtReplaceR.Text;
                            TextEditor.ReplaceSelection(textToReplace);
                        }
                    }
                }
            }
            return FindNextR(searchUp, ref rr);
        }

        public void FindNext()
        {
            SyncSearchText();

            if (string.IsNullOrEmpty(TxtFindF.Text))
                return;

            AddFindMru();
            LblStatus.Text = string.Empty;

            CharacterRange foundRange;

            try
            {
                foundRange = FindNextF(false);
            }
            catch (ArgumentException ex)
            {
                LblStatus.Text = "Error in Regular Expression: " + ex.Message;
                return;
            }

            if (foundRange.cpMin == foundRange.cpMax)
            {
                LblStatus.Text = "Match could not be found";
            }
            else
            {
                if (foundRange.cpMin < TextEditor.AnchorPosition)
                {
                    if (ChkSearchSelectionF.Checked)
                        LblStatus.Text = "Search match wrapped to the beginning of the selection";
                    else
                        LblStatus.Text = "Search match wrapped to the beginning of the document";
                }

                TextEditor.SetSel(foundRange.cpMin, foundRange.cpMax);
                MoveFormAwayFromSelection();
            }
        }

        public void FindPrevious()
        {
            SyncSearchText();

            if (string.IsNullOrEmpty(TxtFindF.Text))
                return;

            AddFindMru();
            LblStatus.Text = string.Empty;
            CharacterRange foundRange;
            try
            {
                foundRange = FindNextF(true);
            }
            catch (ArgumentException ex)
            {
                LblStatus.Text = $"Error in Regular Expression: {ex.Message}";
                return;
            }

            if (foundRange.cpMin == foundRange.cpMax)
            {
                LblStatus.Text = "Match could not be found";
            }
            else
            {
                if (foundRange.cpMin > TextEditor.CurrentPosition)
                {
                    if (ChkSearchSelectionF.Checked)
                        LblStatus.Text = "Search match wrapped to the _end of the selection";
                    else
                        LblStatus.Text = "Search match wrapped to the _end of the document";
                }

                TextEditor.SetSel(foundRange.cpMin, foundRange.cpMax);
                MoveFormAwayFromSelection();
            }
        }

        public SearchFlags GetSearchFlags()
        {
            SearchFlags sf = SearchFlags.None;

            if (TabAll.SelectedTab == TpgFind)
            {
                if (ChkMatchCaseF.Checked)
                    sf |= SearchFlags.MatchCase;

                if (ChkWholeWordF.Checked)
                    sf |= SearchFlags.WholeWord;

                if (ChkWordStartF.Checked)
                    sf |= SearchFlags.WordStart;
            }
            else
            {
                if (ChkMatchCaseR.Checked)
                    sf |= SearchFlags.MatchCase;

                if (ChkWholeWordR.Checked)
                    sf |= SearchFlags.WholeWord;

                if (ChkWordStartR.Checked)
                    sf |= SearchFlags.WordStart;
            }

            return sf;
        }

        public RegexOptions GetRegexOptions()
        {
            RegexOptions ro = RegexOptions.None;

            if (TabAll.SelectedTab == TpgFind)
            {
                if (ChkCompiledF.Checked)
                    ro |= RegexOptions.Compiled;

                if (ChkCulturalInvariantF.Checked)
                    ro |= RegexOptions.Compiled;

                if (ChkEcmaScriptF.Checked)
                    ro |= RegexOptions.ECMAScript;

                if (ChkExplicitCaptureF.Checked)
                    ro |= RegexOptions.ExplicitCapture;

                if (ChkIgnoreCaseF.Checked)
                    ro |= RegexOptions.IgnoreCase;

                if (ChkIgnorePatternWhitespaceF.Checked)
                    ro |= RegexOptions.IgnorePatternWhitespace;

                if (ChkMultilineF.Checked)
                    ro |= RegexOptions.Multiline;

                if (ChkRightToLeftF.Checked)
                    ro |= RegexOptions.RightToLeft;

                if (ChkSinglelineF.Checked)
                    ro |= RegexOptions.Singleline;
            }
            else
            {
                if (ChkCompiledR.Checked)
                    ro |= RegexOptions.Compiled;

                if (ChkCulturalInvariantR.Checked)
                    ro |= RegexOptions.Compiled;

                if (ChkEcmaScriptR.Checked)
                    ro |= RegexOptions.ECMAScript;

                if (ChkExplicitCaptureR.Checked)
                    ro |= RegexOptions.ExplicitCapture;

                if (ChkIgnoreCaseR.Checked)
                    ro |= RegexOptions.IgnoreCase;

                if (ChkIgnorePatternWhitespaceR.Checked)
                    ro |= RegexOptions.IgnorePatternWhitespace;

                if (ChkMultilineR.Checked)
                    ro |= RegexOptions.Multiline;

                if (ChkRightToLeftR.Checked)
                    ro |= RegexOptions.RightToLeft;

                if (ChkSinglelineR.Checked)
                    ro |= RegexOptions.Singleline;
            }

            return ro;
        }

        private void SyncSearchText()
        {
            if (TabAll.SelectedTab == TpgFind)
                TxtFindR.Text = TxtFindF.Text;
            else
                TxtFindF.Text = TxtFindR.Text;
        }

        private void AddFindMru()
        {
            string find = TxtFindF.Text;
            _mruFind.Remove(find);

            _mruFind.Insert(0, find);

            if (_mruFind.Count > _mruMaxCount)
                _mruFind.RemoveAt(_mruFind.Count - 1);

            _bindingSourceFind.ResetBindings(false);
        }

        private void AddReplaceMru()
        {
            string find = TxtFindR.Text;
            _mruFind.Remove(find);

            _mruFind.Insert(0, find);

            if (_mruFind.Count > _mruMaxCount)
                _mruFind.RemoveAt(_mruFind.Count - 1);

            string replace = TxtReplaceR.Text;
            if (replace != string.Empty)
            {
                _mruReplace.Remove(replace);

                _mruReplace.Insert(0, replace);

                if (_mruReplace.Count > _mruMaxCount)
                    _mruReplace.RemoveAt(_mruReplace.Count - 1);
            }

            _bindingSourceFind.ResetBindings(false);
            _bindingSourceReplace.ResetBindings(false);
        }

        private CharacterRange FindNextF(bool searchUp)
        {
            CharacterRange foundRange;

            if (RbtnRegexF.Checked)
            {
                Regex rr = new Regex(TxtFindF.Text, GetRegexOptions());

                if (ChkSearchSelectionF.Checked)
                {
                    if (_searchRange.cpMin == _searchRange.cpMax)
                        _searchRange = new CharacterRange(_textEditor.Selections[0].Start, _textEditor.Selections[0].End);

                    if (searchUp)
                        foundRange = FindReplace.FindPrevious(rr, ChkWrapF.Checked, _searchRange);
                    else
                        foundRange = FindReplace.FindNext(rr, ChkWrapF.Checked, _searchRange);
                }
                else
                {
                    _searchRange = new CharacterRange();
                    if (searchUp)
                        foundRange = FindReplace.FindPrevious(rr, ChkWrapF.Checked);
                    else
                        foundRange = FindReplace.FindNext(rr, ChkWrapF.Checked);
                }
            }
            else
            {
                if (ChkSearchSelectionF.Checked)
                {
                    if (_searchRange.cpMin == _searchRange.cpMax)
                        _searchRange = new CharacterRange(_textEditor.Selections[0].Start, _textEditor.Selections[0].End);

                    if (searchUp)
                    {
                        string textToFind = RbtnExtendedF.Checked ? FindReplace.Transform(TxtFindF.Text) : TxtFindF.Text;
                        foundRange = FindReplace.FindPrevious(textToFind, ChkWrapF.Checked, GetSearchFlags(), _searchRange);
                    }
                    else
                    {
                        string textToFind = RbtnExtendedF.Checked ? FindReplace.Transform(TxtFindF.Text) : TxtFindF.Text;
                        foundRange = FindReplace.FindNext(textToFind, ChkWrapF.Checked, GetSearchFlags(), _searchRange);
                    }
                }
                else
                {
                    _searchRange = new CharacterRange();
                    if (searchUp)
                    {
                        string textToFind = RbtnExtendedF.Checked ? FindReplace.Transform(TxtFindF.Text) : TxtFindF.Text;
                        foundRange = FindReplace.FindPrevious(textToFind, ChkWrapF.Checked, GetSearchFlags());
                    }
                    else
                    {
                        string textToFind = RbtnExtendedF.Checked ? FindReplace.Transform(TxtFindF.Text) : TxtFindF.Text;
                        foundRange = FindReplace.FindNext(textToFind, ChkWrapF.Checked, GetSearchFlags());
                    }
                }
            }
            return foundRange;
        }

        protected override void OnActivated(EventArgs e)
        {
            if (TextEditor.Selections.Count > 0)
            {
                ChkSearchSelectionF.Enabled = true;
                ChkSearchSelectionR.Enabled = true;
            }
            else
            {
                ChkSearchSelectionF.Enabled = false;
                ChkSearchSelectionR.Enabled = false;
                ChkSearchSelectionF.Checked = false;
                ChkSearchSelectionR.Checked = false;
            }

            //	if they leave the dialog and come back any "Search Selection"
            //	range they might have had is invalidated
            _searchRange = new CharacterRange();

            LblStatus.Text = string.Empty;

            MoveFormAwayFromSelection();
            base.OnActivated(e);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            //	So what we're doing here is testing for any of the find/replace
            //	command shortcut bindings. If the key combination matches we send
            //	the KeyEventArgs back to Scintilla so it can be processed. That
            //	way things like Find Next, Show Replace are all available from
            //	the dialog using Scintilla's configured Shortcuts

            //List<KeyBinding> findNextBinding = Scintilla.Commands.GetKeyBindings(BindableCommand.FindNext);
            //List<KeyBinding> findPrevBinding = Scintilla.Commands.GetKeyBindings(BindableCommand.FindPrevious);
            //List<KeyBinding> showFindBinding = Scintilla.Commands.GetKeyBindings(BindableCommand.ShowFind);
            //List<KeyBinding> showReplaceBinding = Scintilla.Commands.GetKeyBindings(BindableCommand.ShowReplace);

            //KeyBinding kb = new KeyBinding(e.KeyCode, e.Modifiers);

            //if (findNextBinding.Contains(kb) || findPrevBinding.Contains(kb) || showFindBinding.Contains(kb) || showReplaceBinding.Contains(kb))
            //{
            //Scintilla. FireKeyDown(e);
            //}

            if (KeyPressed != null)
                KeyPressed(this, e);

            if (e.KeyCode == Keys.Escape)
                Hide();

            base.OnKeyDown(e);
        }

        #endregion

        private void TpgFind_Click(object sender, EventArgs e)
        {

        }

        private void GrpFindAllF_Enter(object sender, EventArgs e)
        {

        }

        private void ChkHighlightMatchesF_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChkMarkLineF_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GrpOptionsF_Enter(object sender, EventArgs e)
        {

        }

        private void PnlStandardOptionsF_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ChkWordStartF_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChkWholeWordF_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChkMatchCaseF_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PnlRegexpOptionsF_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ChkSinglelineF_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChkRightToLeftF_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChkMultilineF_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChkIgnorePatternWhitespaceF_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChkIgnoreCaseF_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChkExplicitCaptureF_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChkCulturalInvariantF_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChkCompiledF_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChkSearchSelectionF_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChkWrapF_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RbtnRegexF_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RbtnExtendedF_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LblSearchTypeF_Click(object sender, EventArgs e)
        {

        }

        private void TxtFindF_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblFind_Click(object sender, EventArgs e)
        {

        }

        private void TpgReplace_Click(object sender, EventArgs e)
        {

        }

        private void BtnFindPrevious_Click(object sender, EventArgs e)
        {

        }

        private void BtnFindNext_Click(object sender, EventArgs e)
        {

        }

        private void GrpOptionsR_Enter(object sender, EventArgs e)
        {

        }

        private void PnlStandardOptionsR_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ChkWordStartR_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChkWholeWordR_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChkMatchCaseR_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PnlRegexpOptionsR_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ChkSinglelineR_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChkRightToLeftR_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChkMultilineR_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChkIgnorePatternWhitespaceR_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChkIgnoreCaseR_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChkExplicitCaptureR_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChkCulturalInvariantR_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChkCompiledR_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChkSearchSelectionR_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChkWrapR_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RbtnRegexR_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RbtnExtendedR_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LblSearchTypeR_Click(object sender, EventArgs e)
        {

        }

        private void TxtReplaceR_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblReplaceR_Click(object sender, EventArgs e)
        {

        }

        private void TxtFindR_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblFindR_Click(object sender, EventArgs e)
        {

        }

        private void StatusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void LblStatus_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void mnuExtendedCharFindF_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {

        }

        private void nNewLineToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rCarriageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tTabToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void nullCharactorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuRecentFindF_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void mnuExtendedCharReplace_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {

        }

        private void mnuExtendedCharFindR_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void mnuRecentFindR_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void mnuRecentReplace_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void mnuRegExCharFindF_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem25_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem26_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem27_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem28_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem29_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem22_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem21_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem23_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem24_Click(object sender, EventArgs e)
        {

        }

        private void mnuRegExCharFindR_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void toolStripMenuItem30_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem31_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem32_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem33_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem34_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem35_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem36_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem37_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem38_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem39_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem40_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem41_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem42_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem43_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator7_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem44_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem45_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator8_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem46_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem47_Click(object sender, EventArgs e)
        {

        }

        private void mnuRegExCharReplace_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void toolStripMenuItem48_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem49_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem57_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem56_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem55_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem54_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem53_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem52_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem51_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem50_Click(object sender, EventArgs e)
        {

        }

        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
