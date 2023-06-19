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
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void AddBrand(Brand category)
        {
            _brandDal.Add(category);
        }

        public Brand GetById(int id)
        {
            return _brandDal.Get(b=> b.Id == id);
        }

        public List<Brand> GetBrands()
        {
            return _brandDal.GetAll();
        }


        public void UpdateBrand(Brand brand)
        {
            var result = _brandDal.GetAll(b=>b.Id == brand.Id).Count;
            if (result > 0)
                _brandDal.Update(brand);
        }

        public void DeleteBrand(Brand brand)
        {
            var result = _brandDal.GetAll(b=>b.Id == brand.Id).Count;
            if(result > 0)
                _brandDal.Delete(brand);
        }
    }
}
