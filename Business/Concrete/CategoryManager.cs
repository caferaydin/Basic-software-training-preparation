using SmartPro.Business.Abstraction;
using SmartPro.Business.BusinessAspects.Autofac;
using SmartPro.Business.Rules.Validation.Fluent;
using SmartPro.Core.Aspects.Autofac.Caching;
using SmartPro.Core.Aspects.Autofac.Performance;
using SmartPro.Core.Aspects.Autofac.Validation;
using SmartPro.Core.Utilities.Result;
using SmartPro.DataAccess.Abstraction;
using SmartPro.Entities.Concrete;

namespace SmartPro.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        [PerformanceAspect(10)]
        [CacheAspect]
        public IDataResult<List<Category>> GetCategories()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll(), "List of Category");
        }
        [PerformanceAspect(5)]
        [CacheAspect]
        public IDataResult<Category> GetById(int id)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(c => c.Id == id));
        }


        //[SecuredOperation("CategoryManager,Admin")]
        [CacheRemoveAspect("ICategoryService.Get")]
        [ValidationAspect(typeof(CategoryValidator))]
        public IResult AddCategory(Category category)
        {
            _categoryDal.Add(category);
            return new SuccessResult("Added");
        }

        //[SecuredOperation("CategoryManager,Admin")]
        [CacheRemoveAspect("ICategoryService.Get")]
        public IResult Update(Category category)
        {
            var result = _categoryDal.GetAll(c=> c.Id == category.Id).Count;
            if(result > 0) 
                _categoryDal.Update(category);
            return new SuccessResult("Updated");

        }
        //[SecuredOperation("CategoryManager,Admin")]
        [CacheRemoveAspect("ICategoryService.Get")]
        public IResult Delete(Category category)
        {
            var result = _categoryDal.GetAll(c => c.Id == category.Id).Count;
            if (result > 0)
                _categoryDal.Delete(category);
            return new SuccessResult("Deleted");

        }
    }
}
