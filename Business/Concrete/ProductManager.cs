using SmartPro.Business.Abstraction;
using SmartPro.Business.BusinessAspects.Autofac;
using SmartPro.Business.Rules.Validation.Fluent;
using SmartPro.Core.Aspects.Autofac.Caching;
using SmartPro.Core.Aspects.Autofac.Performance;
using SmartPro.Core.Aspects.Autofac.Validation;
using SmartPro.Core.Utilities.Result;
using SmartPro.DataAccess.Abstraction;
using SmartPro.Entities.Concrete;
using SmartPro.Entities.DTO.Product;

namespace SmartPro.Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        [PerformanceAspect(10)]
        [CacheAspect]
        public IDataResult<List<Product>> GetAll()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(), "List of Product");
        }

        [PerformanceAspect(10)]
        [CacheAspect]
        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.CategoryId == id), "List of Product in Category");
        }

        [PerformanceAspect(5)]
        [CacheAspect]
        public IDataResult<Product> GetById(int id)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.Id == id), "Product listed");
        }

        [PerformanceAspect(5)]
        [CacheAspect]
        public IDataResult<List<Product>> GetByPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.Price >= min && p.Price <= max), "Filtered products listed");
        }

        [PerformanceAspect(5)]
        [CacheAspect]
        public IDataResult<List<ProductDto>> GetProductDtos()
        {
            return new SuccessDataResult<List<ProductDto>>(_productDal.GetProductDtos(), "Get Product Listed");
        }

        [CacheRemoveAspect("IProductService.Get")]
        [SecuredOperation("ProductManager,Admin,CustomerProductAdd")]
        [ValidationAspect(typeof(ProductValidator))]
        public IResult AddProduct(Product product)
        {
            _productDal.Add(product);
            return new SuccessResult("Added!");
        }
         
        [CacheRemoveAspect("IProductService.Get")]
        //[SecuredOperation("ProductManager,Admin,CustomerProductAdd")]
        public IResult UpdateProduct(Product product)
        {
            var result = _productDal.GetAll(p => p.Id == product.Id).Count;
            if (result > 0)
                _productDal.Update(product);
            return new SuccessResult("Updated");
        }
        
        [CacheRemoveAspect("IProductService.Get")]
        //[SecuredOperation("ProductManager,Admin,CustomerProductAdd")]
        public IResult DeleteProduct(Product product)
        {
            var result = _productDal.GetAll(p=>p.Id == product.Id).Count;
            if (result > 0) 
                _productDal.Delete(product);
            return new SuccessResult("Deleted");
        }
    }
}
