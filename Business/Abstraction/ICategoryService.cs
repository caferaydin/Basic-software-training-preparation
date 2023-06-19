using SmartPro.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro.Business.Abstraction
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
        Category GetById(int id);
        void AddCategory(Category category);
        void Update(Category category);
        void Delete(int id);



    }
}
