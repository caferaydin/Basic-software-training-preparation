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

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
        }

        public Brand GetById(int id)
        {
            return _brandDal.Get(b=> b.Id == id);
        }

        public List<Brand> GetBrands()
        {
            return _brandDal.GetAll();
        }

        public void Update(Brand category)
        {
            throw new NotImplementedException();
        }
    }
}
