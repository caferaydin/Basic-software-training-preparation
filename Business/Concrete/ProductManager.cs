using SmartPro.Business.Abstraction;
using SmartPro.DataAccess.Abstraction;
using SmartPro.Entities.Concrete;
using SmartPro.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro.Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p => p.CategoryId == id);
        }

        public Product GetById(int id)
        {
            return _productDal.Get(p => p.Id == id);
        }

        public List<Product> GetByPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.Price >= min && p.Price <= max);
        }

        public List<ProductDto> GetProductDtos()
        {
            return _productDal.GetProductDtos();
        }

        public void AddProduct(Product product)
        {
            _productDal.Add(product);
        }
        public void UpdateProduct(Product product)
        {
            var result = _productDal.GetAll(p => p.Id == product.Id).Count;
            if (result > 0)
                _productDal.Update(product);
        }
        public void DeleteProduct(Product product)
        {
            var result = _productDal.GetAll(p=>p.Id == product.Id).Count;
            if (result > 0) 
                _productDal.Delete(product);
        }

        
    }
}
