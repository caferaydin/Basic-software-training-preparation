using SmartPro.Core.Utilities.Result;
using SmartPro.Entities.Concrete;

namespace SmartPro.Business.Abstraction
{
    public interface IBrandService
    {
        IDataResult<List<Brand>> GetBrands();
        IDataResult<Brand> GetById(int id);
        IResult AddBrand(Brand brand);
        IResult UpdateBrand(Brand brand);
        IResult DeleteBrand(Brand brand);
    }
}
