using SmartPro.Core;

namespace SmartPro.Entities.DTO.Product
{
    public class UserForLoginDto : IDto
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}
