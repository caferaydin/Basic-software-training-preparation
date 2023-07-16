using SmartPro.Core.DataAccess.EntityFramework;
using SmartPro.DataAccess.Abstraction;
using SmartPro.DataAccess.Contexts;
using SmartPro.Entities.Concrete;
using SmartPro.Entities.DTO.Product;

namespace SmartPro.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, MsSqlDbContext>, IProductDal
    {
        public List<ProductDto> GetProductDtos()
        {
            using (MsSqlDbContext context = new MsSqlDbContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.Id
                             join b in context.Brands
                             on p.BrandId equals b.Id
                             select new ProductDto
                             {
                                 Id = p.Id,
                                 ProductName = p.ProductName,
                                 ProductDescription = p.ProductDescription,
                                 CategoryName = c.Name,
                                 BrandName = b.BrandName,
                                 Stock = p.Stock,
                                 Price = p.Price,
                             };
                return result.ToList();
            }
        }
    }
}
