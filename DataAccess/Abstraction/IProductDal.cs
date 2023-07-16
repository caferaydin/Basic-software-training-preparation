using SmartPro.Core.DataAccess;
using SmartPro.Entities.Concrete;
using SmartPro.Entities.DTO.Product;

namespace SmartPro.DataAccess.Abstraction
{
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductDto> GetProductDtos();
    }
}
