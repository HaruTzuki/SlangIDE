using Slang.IDE.Shared.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDE.Controls
{
    public class TreeNodeExtented : TreeNode
    {
        public Guid Id { get; set; }
        public TreeFileType FileType { get; set; }
        public string FilePath { get; set; }
    }
}
