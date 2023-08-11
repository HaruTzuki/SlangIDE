using Slang.IDE.Domain.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slang.IDE.Domain.Entities.Security
{
    public sealed class User : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsEnabled { get; set; }
    }
}
