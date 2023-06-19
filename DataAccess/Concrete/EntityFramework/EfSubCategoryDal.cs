using SmartPro.Core.DataAccess.EntityFramework;
using SmartPro.DataAccess.Abstraction;
using SmartPro.DataAccess.Contexts;
using SmartPro.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro.DataAccess.Concrete.EntityFramework
{
    public class EfSubCategoryDal : EfEntityRepositoryBase<SubCategory, MsSqlDbContext>, ISubCategoryDal
    {
    }
}
