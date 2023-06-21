using SmartPro.Core.DataAccess.EntityFramework;
using SmartPro.DataAccess.Abstraction;
using SmartPro.DataAccess.Contexts;
using SmartPro.Entities.Concrete;

namespace SmartPro.DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand, MsSqlDbContext>, IBrandDal
    {

    }
}
