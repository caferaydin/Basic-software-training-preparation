using SmartPro.Core.Entities;
using SmartPro.Entities.Concrete.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro.Entities.Concrete
{
    public class Product : BaseEntity, IEntity
    {
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public int BrandId { get; set; }
        public string? ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }

    }
}
