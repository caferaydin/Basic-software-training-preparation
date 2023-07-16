using SmartPro.Core.DataAccess;
using SmartPro.Entities.Concrete;
using SmartPro.Entities.DTO.Category;

namespace SmartPro.DataAccess.Abstraction
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
        List<CategoryDto> GetAllSubCategories();
    }
}
