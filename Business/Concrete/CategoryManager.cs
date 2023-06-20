using SmartPro.Business.Abstraction;
using SmartPro.Core.Utilities.Result;
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
        public IDataResult<List<Category>> GetCategories()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll(), "List of Category");
        }
        public IDataResult<Category> GetById(int id)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(c => c.Id == id));
        }
        public IResult AddCategory(Category category)
        {
            _categoryDal.Add(category);
            return new SuccessResult("Added");
        }
        public IResult Update(Category category)
        {
            var result = _categoryDal.GetAll(c=> c.Id == category.Id).Count;
            if(result > 0) 
                _categoryDal.Update(category);
            return new SuccessResult("Updated");

        }
        public IResult Delete(Category category)
        {
            var result = _categoryDal.GetAll(c => c.Id == category.Id).Count;
            if (result > 0)
                _categoryDal.Delete(category);
            return new SuccessResult("Deleted");

        }
    }
}
