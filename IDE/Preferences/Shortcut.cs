using IDE.Views.AdditionViews;

namespace IDE.Preferences
{
    public class Shortcut
    {
        public static Dictionary<Keys, Action<RichTextBox>> EditorsShortcuts;

        [EditorText("Editor.Copy")]
        public Keys EditorCopy { get; set; } = Keys.Control | Keys.C;
        [EditorText("Editor.Paste")]
        public Keys EditorPaste { get; set; } = Keys.Control | Keys.V;
        [EditorText("Editor.Cut")]
        public Keys EditorCut { get; set; } = Keys.Control | Keys.X;
        [EditorText("Editor.SelectAll")]
        public Keys EditorSelectAll { get; set; } = Keys.Control | Keys.A;
        [EditorText("Editor.Find")]
        public Keys EditorFind { get; set; } = Keys.Control | Keys.F;
        [EditorText("Editor.Replace")]
        public Keys EditorReplace { get; set; } = Keys.Control | Keys.H;
        [EditorText("Editor.Undo")]
        public Keys EditorUndo { get; set; } = Keys.Control | Keys.Z;
        [EditorText("Editor.Redo")]
        public Keys EditorRedo { get; set; } = Keys.Control | Keys.Y;

        public void Bind()
        {
            EditorsShortcuts ??= new Dictionary<Keys, Action<RichTextBox>>();
            EditorsShortcuts.Clear();
            EditorsShortcuts.Add(EditorCopy, (r) => r.Copy());
            EditorsShortcuts.Add(EditorPaste, (r) => r.Paste());
            EditorsShortcuts.Add(EditorCut, (r) => r.Cut());
            EditorsShortcuts.Add(EditorSelectAll, (r) => r.SelectAll());
            //EditorsShortcuts.Add(EditorFind, (r) => { var form = new FrmFindReplace(ref r, r.SelectedText, false); form.Show(); });
            //EditorsShortcuts.Add(EditorReplace, (r) => { var form = new FrmFindReplace(ref r, r.SelectedText, true); form.Show(); });
            EditorsShortcuts.Add(EditorUndo, (r) => r.Undo());
            EditorsShortcuts.Add(EditorRedo, (r) => r.Redo());
        }
    }
}
