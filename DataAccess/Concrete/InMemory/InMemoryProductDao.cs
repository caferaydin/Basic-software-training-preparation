using SmartPro.DataAccess.Abstraction;
using SmartPro.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro.DataAccess.Concrete.InMemory
{
    public class InMemoryProductDao : IProductDao
    {
       List<Product> _products;

        public InMemoryProductDao()
        {
            _products = new List<Product>
            {
                new() {Id = Guid.NewGuid(), CategoryId=Guid.NewGuid(), Name="Product 1", Description="Product Description", Stock=10, Price=1.500F, CreatedAt=DateTime.Now },
                new() {Id = Guid.NewGuid(), CategoryId=Guid.NewGuid(), Name="Product 2", Description="Product Description", Stock=5, Price=1.000F, CreatedAt=DateTime.Now },
                new() {Id = Guid.NewGuid(), CategoryId=Guid.NewGuid(), Name="Product 3", Description="Product Description", Stock=3, Price=500F, CreatedAt=DateTime.Now },
            };
                
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //Product productToDelete = null;

            //foreach (var p in _products)
            //{
            //    if(product.Id == p.Id)
            //    {
            //        productToDelete = p;
            //    }
            //}

            Product productToDelete = _products.SingleOrDefault(p => p.Id == product.Id);

            _products.Remove(productToDelete);
        }

        public List<Product> GetAllByCategory(Guid categoryId)
        {
            return _products.Where(p=> p.CategoryId == categoryId).ToList();
        }

        public List<Product> GetProducts()
        {
            return _products;
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p=> p.Id == product.Id);
            productToUpdate.Name = product.Name;
            productToUpdate.Description = product.Description;
            productToUpdate.Stock = product.Stock;
            productToUpdate.UpdatedAt = DateTime.Now;

            _products.Add(productToUpdate);
        }
    }
}
