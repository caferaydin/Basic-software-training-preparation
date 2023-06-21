namespace SmartPro.Core.Entities.Concrete.Roles
{
    public class User : IEntity
    {
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public byte[]? PasswordHash { get; set; }
        public byte[]? PasswordSalt { get; set; }
        public bool Status { get; set; }

        //public string? Address { get; set; }
        //public string? City { get; set; }
        //public string? Region { get; set; }
        //public string? PostalCode { get; set; }
        //public string? Country { get; set; }
        //public string? PhoneNumber { get; set; }
    }
}
