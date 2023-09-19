namespace IDE.Preferences
{
    internal class EditorTextAttribute : Attribute
    {
        private string _v;

        public EditorTextAttribute(string v)
        {
            _v = v;
        }
    }
}