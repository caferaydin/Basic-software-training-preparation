using SmartPro.Core.Entities;
using SmartPro.Entities.Concrete.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro.Entities.Concrete
{
    public class SubCategory : BaseEntity, IEntity
    {
        public int CategoryId { get; set; }
        public string? SubCategoryName { get; set; }
    }
}
