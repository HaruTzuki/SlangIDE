using Slang.IDE.Shared.Enumerations;

namespace IDE.Controls
{
    public class TreeNodeExtented : TreeNode
    {
        public Guid Id { get; set; }
        public TreeFileType FileType { get; set; }
        public string FilePath { get; set; }
    }
}
