using Slang.IDE.Shared.Enumerations;

namespace IDE.Preferences
{
    public class SlangProject
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string FilePath { get; set; }
        public TreeFileType FileType { get; set; }
        public List<SlangProjectFiles> Files { get; set; } = new List<SlangProjectFiles>();
    }

    public class SlangProjectFiles
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string FilePath { get; set; }
        public TreeFileType FileType { get; set; }

        public Guid? ParentId { get; set; }

    }
}
