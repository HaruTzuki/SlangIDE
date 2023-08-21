using System;
using System.Collections.Generic;
using System.Text;

namespace Slang.IDE.Domain.Entities.IDE
{
    public sealed class Project
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public bool IsPinned { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
