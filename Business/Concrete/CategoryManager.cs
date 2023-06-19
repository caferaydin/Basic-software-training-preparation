using SmartPro.Business.Abstraction;
using SmartPro.DataAccess.Abstraction;
using SmartPro.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void AddCategory(Category category)
        {
            _categoryDal.Add(category);
        }


        public void Delete(Category category)
        {
            var result = _categoryDal.GetAll(c=> c.Id == category.Id).Count;
            if(result > 0) 
                _categoryDal.Delete(category);
        }

        public Category GetById(int id)
        {
            return _categoryDal.Get(c=>c.Id == id);
        }

        public List<Category> GetCategories()
        {
            return _categoryDal.GetAll();
        }

        public void Update(Category category)
        {
            var result = _categoryDal.GetAll(c=> c.Id == category.Id).Count;
            if(result > 0) 
                _categoryDal.Update(category);
            
        }
    }
}
