using SmartPro.Core.DataAccess.EntityFramework;
using SmartPro.DataAccess.Abstraction;
using SmartPro.DataAccess.Contexts;
using SmartPro.Entities.Concrete;
using SmartPro.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                             join s in context.SubCategories
                             on p.SubCategoryId equals s.Id
                             join b in context.Brands
                             on p.BrandId equals b.Id
                             select new ProductDto
                             {
                                 Id = p.Id,
                                 ProductName = p.ProductName,
                                 ProductDescription = p.ProductDescription,
                                 CategoryName = c.CategoryName,
                                 SubCategoryName = s.SubCategoryName,
                                 BrandName = b.BrandName,
                                 Stock = p.Stock,
                                 Price = p.Price,
                             };
                return result.ToList();
            }
        }
    }
}
