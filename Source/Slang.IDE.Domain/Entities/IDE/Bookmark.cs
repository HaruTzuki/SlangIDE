namespace Slang.IDE.Domain.Entities.IDE
{
#nullable disable
    public class Bookmark
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string FilePath { get; set; }
        public int Line { get; set; }
    }
}
