using SmartPro.Core.Entities;
using SmartPro.Entities.Concrete.Common;

namespace SmartPro.Entities.Concrete
{
    public class Category : BaseEntity, IEntity
    {
        public string Name { get; set; }
        public int? ParentCategoryId { get; set; }
        public List<Category>? Subcategories { get; set; }

    }
}
