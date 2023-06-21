using SmartPro.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro.Entities.DTO
{
    public class UserForLoginDto : IDto
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}
