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
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        [PerformanceAspect(10)]
        [CacheAspect]
        public IDataResult<List<Brand>> GetBrands()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());
        }
        [PerformanceAspect(5)]
        [CacheAspect]
        public IDataResult<Brand> GetById(int id)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(b=> b.Id == id));
        }

        [SecuredOperation("BrandManager,Admin")]
        [CacheRemoveAspect("IBrandService.Get")]
        [ValidationAspect(typeof(BrandValidator))]
        public IResult AddBrand(Brand category)
        {
            _brandDal.Add(category);
            return new SuccessResult("Added!");
        }

        [SecuredOperation("BrandManager,Admin")]
        [CacheRemoveAspect("IBrandService.Get")]
        [ValidationAspect(typeof(BrandValidator))]
        public IResult UpdateBrand(Brand brand)
        {
            var result = _brandDal.GetAll(b=>b.Id == brand.Id).Count;
            if (result > 0)
                _brandDal.Update(brand);
            return new SuccessResult("Updated!");
        }

        [SecuredOperation("BrandManager,Admin")]
        [CacheRemoveAspect("IBrandService.Get")]
        [ValidationAspect(typeof(BrandValidator))]
        public IResult DeleteBrand(Brand brand)
        {
            var result = _brandDal.GetAll(b=>b.Id == brand.Id).Count;
            if(result > 0)
                _brandDal.Delete(brand);
            return new SuccessResult("Deleted");
        }
    }
}
