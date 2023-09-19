using Slang.IDE.Domain.Abstraction;

namespace Slang.IDE.Domain.Entities.Security
{
    public sealed class User : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsEnabled { get; set; }
    }
}
