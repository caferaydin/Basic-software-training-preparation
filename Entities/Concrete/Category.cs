using SmartPro.Core.Entities;
using SmartPro.Entities.Concrete.Common;

namespace SmartPro.Entities.Concrete
{
    public class Category : BaseEntity, IEntity
    {
        public string? CategoryName { get; set; }
    }
}
