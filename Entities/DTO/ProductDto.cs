using SmartPro.Core;

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
        public int Stock { get; set; }
        public decimal Price { get; set; }
    }
}
