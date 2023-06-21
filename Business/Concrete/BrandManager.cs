using SmartPro.Business.Abstraction;
using SmartPro.Core.Utilities.Result;
using SmartPro.DataAccess.Abstraction;
using SmartPro.Entities.Concrete;

namespace SmartPro.Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IDataResult<List<Brand>> GetBrands()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());
        }
        public IDataResult<Brand> GetById(int id)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(b=> b.Id == id));
        }

        public IResult AddBrand(Brand category)
        {
            _brandDal.Add(category);
            return new SuccessResult("Added!");
        }

        public IResult UpdateBrand(Brand brand)
        {
            var result = _brandDal.GetAll(b=>b.Id == brand.Id).Count;
            if (result > 0)
                _brandDal.Update(brand);
            return new SuccessResult("Updated!");
        }

        public IResult DeleteBrand(Brand brand)
        {
            var result = _brandDal.GetAll(b=>b.Id == brand.Id).Count;
            if(result > 0)
                _brandDal.Delete(brand);
            return new SuccessResult("Deleted");
        }
    }
}
