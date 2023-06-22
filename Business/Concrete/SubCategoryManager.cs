using SmartPro.Business.Abstraction;
using SmartPro.Business.BusinessAspects.Autofac;
using SmartPro.Core.Aspects.Autofac.Caching;
using SmartPro.Core.Aspects.Autofac.Performance;
using SmartPro.Core.Utilities.Result;
using SmartPro.DataAccess.Abstraction;
using SmartPro.Entities.Concrete;

namespace SmartPro.Business.Concrete
{
    public class SubCategoryManager : ISubCategoryService
    {
        ISubCategoryDal _subCategory;

        public SubCategoryManager(ISubCategoryDal subCategory)
        {
            _subCategory = subCategory;
        }
        [PerformanceAspect(10)]
        [CacheAspect]
        public IDataResult<List<SubCategory>> GetSubCategories()
        {
            return new SuccessDataResult<List<SubCategory>>(_subCategory.GetAll(), "IDataResult");
        }
        [PerformanceAspect(5)]
        [CacheAspect]
        public IDataResult<SubCategory> GetById(int id)
        {
            return new SuccessDataResult<SubCategory>(_subCategory.Get(p=>p.Id == id), "IDataResult");
        }

        [CacheRemoveAspect("ISubCategoryService.Get")]
        [SecuredOperation("CategoryManager,SubCategoryManager,Admin")]
        public IResult AddSubCategory(SubCategory subCategory)
        {
            _subCategory.Add(subCategory);
            return new SuccessResult("Added");
        }

        [CacheRemoveAspect("ISubCategoryService.Get")]
        [SecuredOperation("CategoryManager,SubCategoryManager,Admin")]
        public IResult SubCategoryUpdate(SubCategory subCategory)
        {
            var result = _subCategory.GetAll(s=> s.Id == subCategory.Id).Count;
            if(result > 0)
                _subCategory.Update(subCategory);
            return new SuccessResult("Updated");

        }
        [CacheRemoveAspect("ISubCategoryService.Get")]
        [SecuredOperation("CategoryManager,SubCategoryManager,Admin")]
        public IResult SubCategoryDelete(SubCategory subCategory)
        {
            var result = _subCategory.GetAll(s => s.Id == subCategory.Id).Count;
            if (result > 0)
                _subCategory.Delete(subCategory);
            return new SuccessResult("Deleted");

        }
    }
}
