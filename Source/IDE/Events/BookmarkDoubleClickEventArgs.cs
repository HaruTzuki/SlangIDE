using Slang.IDE.Domain.Entities.IDE;

namespace IDE.Events
{
    public class BookmarkDoubleClickEventArgs : EventArgs
    {
        public Bookmark Bookmark { get; set; }
    }
}
