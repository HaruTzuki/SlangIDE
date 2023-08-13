using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDE.Events
{
#nullable disable
    public class BookmarkEventArgs : EventArgs
    {
        public string FileLocation { get; set; }
        public int Line { get; set; }

        public BookmarkEventArgs()
        {
            
        }

        public BookmarkEventArgs(string fileLocation, int line)
        {
            FileLocation = fileLocation;
            Line = line;
        }
    }
}
