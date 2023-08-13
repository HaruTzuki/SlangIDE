using System;
using System.Collections.Generic;
using System.Text;

namespace Slang.IDE.Domain.Entities.IDE
{
    public class Bookmark
    {
        public string Name { get; set; }
        public string FilePath { get; set; }
        public int Line { get; set; }
    }
}
