using SmartPro.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro.Entities.DTO
{
    public class ProductDto : IDto
    {
        public int Id { get; set; }
        public string? CategoryName { get; set; }
        public string? SubCategoryName { get; set; }
        public string? BrandName { get; set; }
        public string? ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public short Stock { get; set; }
        public decimal Price { get; set; }
    }
}
