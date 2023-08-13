using BrightIdeasSoftware;
using IDE.Abstraction;
using Slang.IDE.Cache.Queries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDE.Views.ToolWindows
{
    public partial class ToolWindowBookmarks : ToolWindow
    {
        private readonly FrmMain _frmMain;

        public ToolWindowBookmarks(FrmMain frmMain)
        {
            InitializeComponent();
            _frmMain = frmMain;
            _frmMain.BookmarkChanged += BookmarkChanged;
            
        }

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
                AddBookmarkToList(bookmark.Name, bookmark.FilePath, bookmark.Line.ToString());
            }

            BookmarkListView.Refresh();
        }

        /// <summary>
        /// Insert a bookmark to list
        /// </summary>
        /// <param name="bookmarkName"></param>
        /// <param name="fileLocation"></param>
        /// <param name="lineNumber"></param>
        public void AddBookmarkToList(string bookmarkName, string fileLocation, string lineNumber)
        {
            var listViewItem = new ListViewItem(bookmarkName);
            listViewItem.SubItems.Add(fileLocation);
            listViewItem.SubItems.Add(lineNumber);

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
    }
}
