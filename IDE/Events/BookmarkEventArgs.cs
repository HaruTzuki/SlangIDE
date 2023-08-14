namespace IDE.Events
{
#nullable disable
    public class BookmarkEventArgs : EventArgs
    {
        public string FileId { get; set; }
        public string FileLocation { get; set; }
        public int Line { get; set; }

        public BookmarkEventArgs()
        {

        }

        public BookmarkEventArgs(string fileId, string fileLocation, int line)
        {
            FileId = fileId;
            FileLocation = fileLocation;
            Line = line;
        }
    }
}
