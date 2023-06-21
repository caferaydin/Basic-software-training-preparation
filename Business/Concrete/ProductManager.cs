using SmartPro.Business.Abstraction;
using SmartPro.Core.Utilities.Result;
using SmartPro.DataAccess.Abstraction;
using SmartPro.Entities.Concrete;
using SmartPro.Entities.DTO;

namespace SmartPro.Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IDataResult<List<Product>> GetAll()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(), "List of Product");
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.CategoryId == id), "List of Product in Category");
        }

        public IDataResult<Product> GetById(int id)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.Id == id), "Product listed");
        }

        public IDataResult<List<Product>> GetByPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.Price >= min && p.Price <= max), "Filtered products listed");
        }

        public IDataResult<List<ProductDto>> GetProductDtos()
        {
            return new SuccessDataResult<List<ProductDto>>(_productDal.GetProductDtos(), "Get Product Listed");
        }

        public IResult AddProduct(Product product)
        {
            _productDal.Add(product);
            return new SuccessResult("Added!");
        }
        public IResult UpdateProduct(Product product)
        {
            var result = _productDal.GetAll(p => p.Id == product.Id).Count;
            if (result > 0)
                _productDal.Update(product);
            return new SuccessResult("Updated");
        }
        public IResult DeleteProduct(Product product)
        {
            var result = _productDal.GetAll(p=>p.Id == product.Id).Count;
            if (result > 0) 
                _productDal.Delete(product);
            return new SuccessResult("Deleted");
        }

        
    }
}
