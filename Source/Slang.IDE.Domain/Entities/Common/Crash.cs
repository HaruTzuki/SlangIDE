using Slang.IDE.Domain.Entities.Security;

namespace Slang.IDE.Domain.Entities.Common
{
    public sealed class Crash
    {
        public DateTime CreatedOn { get; set; }
        public string ExceptionMessage { get; set; }
        public string UserExtraInformation { get; set; }
        public Guid? UserId { get; set; }
        public User User { get; set; }
    }
}
