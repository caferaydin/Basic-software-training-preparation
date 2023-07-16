using SmartPro.Core.DataAccess.EntityFramework;
using SmartPro.DataAccess.Abstraction;
using SmartPro.DataAccess.Contexts;
using SmartPro.Entities.Concrete;
using SmartPro.Entities.DTO.Category;

namespace SmartPro.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, MsSqlDbContext>, ICategoryDal
    {
        public List<CategoryDto> GetAllSubCategories()
        {
            using (MsSqlDbContext context = new())
            {
                //var result = from c in context.Categories
                return null;
            }
        }
    }
}
