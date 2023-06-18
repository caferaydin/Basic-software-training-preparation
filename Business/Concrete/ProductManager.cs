using SmartPro.Business.Abstraction;
using SmartPro.DataAccess.Abstraction;
using SmartPro.DataAccess.Concrete.InMemory;
using SmartPro.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro.Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDao _productDao;
        public ProductManager(IProductDao productDao)
        {
            _productDao = productDao;
        }
       
        public List<Product> GetAll()
        {
            return _productDao.GetProducts();
        }
    }
}
