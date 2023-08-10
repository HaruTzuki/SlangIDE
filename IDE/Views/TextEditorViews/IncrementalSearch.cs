using IDE.Components;
using ScintillaNET;
using System.ComponentModel;
using CharacterRange = IDE.Helper.CharacterRange;

namespace IDE.Views.TextEditorViews
{
    public partial class IncrementalSearch : UserControl
    {
        private bool _autoPosition = true;
        private Scintilla _textEditor;
        private bool _toolItem = false;
        private FindReplace _findReplace;


        #region Constructors
        public IncrementalSearch()
        {
            InitializeComponent();
        }

        public IncrementalSearch(bool toolItem)
        {
            InitializeComponent();
            _toolItem = toolItem;
            if (toolItem)
                BackColor = Color.FromArgb(61, 61, 61);
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets whether the control should automatically move away from the current
        /// selection to prevent obscuring it.
        /// </summary>
        /// <returns>true to automatically move away from the current selection; otherwise, false.
        /// If ToolItem is enabled, this defaults to false.</returns>
        public bool AutoPosition
        {
            get
            {
                return _autoPosition;
            }
            set
            {
                if (!ToolItem)
                    _autoPosition = value;
                else
                    _autoPosition = false;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public FindReplace FindReplace
        {
            get
            {
                return _findReplace;
            }
            set
            {
                _findReplace = value;
                if (value != null)
                {
                    _textEditor = _findReplace.TextEditor;
                }
                else
                {
                    _textEditor = null;
                }
            }
        }

        [Browsable(false)]
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

        public bool ToolItem
        {
            get { return _toolItem; }
            set
            {
                _toolItem = value;
                if (_toolItem)
                    BackColor = Color.FromArgb(61, 61, 61);
                else
                    BackColor = Color.FromArgb(61, 61, 61);
            }
        }

        #endregion Properties

        #region Event Handlers
        private void BtnNext_Click(object sender, EventArgs e)
        {
            findNext();
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            findPrevious();
        }

        private void btnClearHighlights_Click(object sender, EventArgs e)
        {
            if (_textEditor == null)
                return;
            _findReplace.ClearAllHighlights();
        }

        private void btnHighlightAll_Click(object sender, EventArgs e)
        {
            if (TxtFind.Text == string.Empty)
                return;
            if (_textEditor == null)
                return;

            int foundCount = _findReplace.FindAll(TxtFind.Text, false, true).Count;
        }
        #endregion

        #region Methods
        public virtual void MoveFormAwayFromSelection()
        {
            if (!Visible || _textEditor == null)
                return;

            if (!AutoPosition)
                return;

            int pos = _textEditor.CurrentPosition;
            int x = _textEditor.PointXFromPosition(pos);
            int y = _textEditor.PointYFromPosition(pos);

            Point cursorPoint = new Point(x, y);

            Rectangle r = new Rectangle(Location, Size);

            if (_textEditor != null)
            {
                r.Location = new Point(_textEditor.ClientRectangle.Right - Size.Width, 0);
            }

            if (r.Contains(cursorPoint))
            {
                Point newLocation;
                if (cursorPoint.Y < (Screen.PrimaryScreen.Bounds.Height / 2))
                {
                    //TODO - replace lineheight with ScintillaNET command, when added
                    int SCI_TEXTHEIGHT = 2279;
                    int lineHeight = _textEditor.DirectMessage(SCI_TEXTHEIGHT, IntPtr.Zero, IntPtr.Zero).ToInt32();
                    // Top half of the screen
                    newLocation = new Point(r.X, cursorPoint.Y + lineHeight * 2);
                }
                else
                {
                    //TODO - replace lineheight with ScintillaNET command, when added
                    int SCI_TEXTHEIGHT = 2279;
                    int lineHeight = _textEditor.DirectMessage(SCI_TEXTHEIGHT, IntPtr.Zero, IntPtr.Zero).ToInt32();
                    // Bottom half of the screen
                    newLocation = new Point(r.X, cursorPoint.Y - Height - (lineHeight * 2));
                }

                Location = newLocation;
            }
            else
            {
                Location = r.Location;
            }
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            MoveFormAwayFromSelection();
            TxtFind.Focus();
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLostFocus(e);
            if (!_toolItem)
                Hide();
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);

            TxtFind.Text = string.Empty;
            TxtFind.BackColor = Color.FromArgb(61, 61, 61);

            MoveFormAwayFromSelection();

            if (Visible)
                TxtFind.Focus();
            else if (_textEditor != null)
                _textEditor.Focus();
        }

        private void findNext()
        {
            if (TxtFind.Text == string.Empty)
                return;
            if (_textEditor == null)
                return;

            CharacterRange r = _findReplace.FindNext(TxtFind.Text, true, _findReplace.Window.GetSearchFlags());
            if (r.cpMin != r.cpMax)
                _textEditor.SetSel(r.cpMin, r.cpMax);

            MoveFormAwayFromSelection();
        }

        private void findPrevious()
        {
            if (TxtFind.Text == string.Empty)
                return;
            if (_textEditor == null)
                return;

            CharacterRange r = _findReplace.FindPrevious(TxtFind.Text, true, _findReplace.Window.GetSearchFlags());
            if (r.cpMin != r.cpMax)
                _textEditor.SetSel(r.cpMin, r.cpMax);

            MoveFormAwayFromSelection();
        }

        private void txtFind_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                case Keys.Down:
                    findNext();
                    e.Handled = true;
                    break;

                case Keys.Up:
                    findPrevious();
                    e.Handled = true;
                    break;

                case Keys.Escape:
                    if (!_toolItem)
                        Hide();
                    break;
            }
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            TxtFind.BackColor = Color.FromArgb(61, 61, 61);

            if (string.IsNullOrEmpty(TxtFind.Text))
                return;

            if (_textEditor == null)
                return;

            int pos = Math.Min(_textEditor.CurrentPosition, _textEditor.AnchorPosition);

            CharacterRange r = _findReplace.Find(pos, _textEditor.TextLength, TxtFind.Text, _findReplace.Window.GetSearchFlags());

            if (r.cpMin == r.cpMax)
                r = _findReplace.Find(0, pos, TxtFind.Text, _findReplace.Window.GetSearchFlags());

            if (r.cpMin != r.cpMax)
                _textEditor.SetSel(r.cpMin, r.cpMax);
            else
                TxtFind.BackColor = Color.Tomato;

            MoveFormAwayFromSelection();
        }
        #endregion
    }
}
