using SmartPro.Core.DataAccess;
using SmartPro.Entities.Concrete;
using SmartPro.Entities.DTO;

namespace SmartPro.DataAccess.Abstraction
{
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductDto> GetProductDtos();
    }
}
