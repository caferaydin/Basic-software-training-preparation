using SmartPro.Core.Utilities.Result;
using SmartPro.Entities.Concrete;
using SmartPro.Entities.DTO.Product;

namespace SmartPro.Business.Abstraction
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<Product> GetById(int id);
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult<List<Product>> GetByPrice(decimal min, decimal max);
        IDataResult<List<ProductDto>> GetProductDtos();
        IResult AddProduct(Product product);
        IResult UpdateProduct(Product product);
        IResult DeleteProduct(Product product);

    }
}
