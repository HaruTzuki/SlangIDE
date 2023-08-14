using IDE.Abstraction;
using IDE.Events;
using Slang.IDE.Cache.Queries;
using Slang.IDE.Shared.Extensions;

namespace IDE.Views.ToolWindows
{
    public partial class ToolWindowBookmarks : ToolWindow
    {
        private readonly FrmMain _frmMain;

        #region Events
        public event EventHandler<BookmarkDoubleClickEventArgs> ItemDoubleClick;
        #endregion

#pragma warning disable CS8618
        public ToolWindowBookmarks(FrmMain frmMain)
        {
            InitializeComponent();
            _frmMain = frmMain;
            _frmMain.BookmarkChanged += BookmarkChanged;

        }
#pragma warning restore CS8618

        private void BookmarkChanged(object sender, EventArgs e)
        {
            RetriveBookmarks();
        }

        private void RetriveBookmarks()
        {
            ClearBookmarkList();

            var mRet = BookmarkQueriesCollection.FetchAll();

            foreach (var bookmark in mRet)
            {
                AddBookmarkToList(bookmark.Id, bookmark.Name, bookmark.FilePath, bookmark.Line.ToString());
            }

            BookmarkListView.Refresh();
        }

        /// <summary>
        /// Insert a bookmark to list
        /// </summary>
        /// <param name="bookmarkName"></param>
        /// <param name="fileLocation"></param>
        /// <param name="lineNumber"></param>
        public void AddBookmarkToList(string id, string bookmarkName, string fileLocation, string lineNumber)
        {
            var listViewItem = new ListViewItem(bookmarkName);
            listViewItem.SubItems.Add(fileLocation);
            listViewItem.SubItems.Add(lineNumber);
            listViewItem.SubItems.Add(id);

            BookmarkListView.Items.Add(listViewItem);
        }

        /// <summary>
        /// Clear the list.
        /// </summary>
        public void ClearBookmarkList()
        {
            BookmarkListView.Items.Clear();
        }

        /// <summary>
        /// Remove the selected bookmark
        /// </summary>
        public void RemoveSelectedBookmark()
        {
            var selectedBookmark = BookmarkListView.SelectedItems[0];

            if (selectedBookmark != null)
            {
                BookmarkListView.Items.Remove(selectedBookmark);
            }
        }

        private void ToolWindowBookmarks_Load(object sender, EventArgs e)
        {
            RetriveBookmarks();
        }

        private void BookmarkListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var info = BookmarkListView.HitTest(e.X, e.Y);
            var item = info.Item;

            if (item is null)
                return;

            ItemDoubleClick?.Invoke(this, new BookmarkDoubleClickEventArgs
            {
                Bookmark = new()
                {
                    Name = item.SubItems[0].Text,
                    FilePath = item.SubItems[1].Text,
                    Line = item.SubItems[2].Text.AsInt(),
                    Id = item.SubItems[3].Text
                }
            });
        }
    }
}
