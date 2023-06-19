using SmartPro.Core.DataAccess;
using SmartPro.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro.DataAccess.Abstraction
{
    public interface ISubCategoryDal : IEntityRepository<SubCategory>
    {
    }
}
