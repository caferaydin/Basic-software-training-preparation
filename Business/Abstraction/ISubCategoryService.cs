using SmartPro.Core.Utilities.Result;
using SmartPro.Entities.Concrete;

namespace SmartPro.Business.Abstraction
{
    public interface ISubCategoryService
    {
        IDataResult<List<SubCategory>> GetSubCategories();
        IDataResult<SubCategory> GetById(int id);
        IResult AddSubCategory(SubCategory subCategory);
        IResult SubCategoryUpdate(SubCategory subCategory);
        IResult SubCategoryDelete(SubCategory subCategory);

    }
}
