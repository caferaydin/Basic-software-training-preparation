using SmartPro.Core.Entities;
using SmartPro.Entities.Concrete.Common;

namespace SmartPro.Entities.Concrete
{
    public class Brand : BaseEntity, IEntity
    {
        public string? BrandName { get; set; }

    }
}
