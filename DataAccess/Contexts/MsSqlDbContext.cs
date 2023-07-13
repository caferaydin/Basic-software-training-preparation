using Microsoft.EntityFrameworkCore;
using SmartPro.Core.Entities.Concrete.Roles;
using SmartPro.Entities.Concrete;

namespace SmartPro.DataAccess.Contexts
{
    public class MsSqlDbContext : DbContext
    {
        public MsSqlDbContext(DbContextOptions option): base(option)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
