using SmartPro.Core.Entities;
using SmartPro.Entities.Concrete.Common;

namespace SmartPro.Entities.Concrete
{
    public class SubCategory : BaseEntity, IEntity
    {
        public int CategoryId { get; set; }
        public string? SubCategoryName { get; set; }
    }
}
