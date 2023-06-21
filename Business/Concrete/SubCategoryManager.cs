using SmartPro.Business.Abstraction;
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
        public IDataResult<List<SubCategory>> GetSubCategories()
        {
            return new SuccessDataResult<List<SubCategory>>(_subCategory.GetAll(), "IDataResult");
        }
        public IDataResult<SubCategory> GetById(int id)
        {
            return new SuccessDataResult<SubCategory>(_subCategory.Get(p=>p.Id == id), "IDataResult");
        }
        public IResult AddSubCategory(SubCategory subCategory)
        {
            _subCategory.Add(subCategory);
            return new SuccessResult("Added");
        }
        public IResult SubCategoryUpdate(SubCategory subCategory)
        {
            var result = _subCategory.GetAll(s=> s.Id == subCategory.Id).Count;
            if(result > 0)
                _subCategory.Update(subCategory);
            return new SuccessResult("Updated");

        }
        public IResult SubCategoryDelete(SubCategory subCategory)
        {
            var result = _subCategory.GetAll(s => s.Id == subCategory.Id).Count;
            if (result > 0)
                _subCategory.Delete(subCategory);
            return new SuccessResult("Deleted");

        }
    }
}
