using SmartPro.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro.Business.Abstraction
{
    public interface IBrandService
    {
        List<Brand> GetBrands();
        Brand GetById(int id);
        void AddBrand(Brand brand);
        void UpdateBrand(Brand brand);
        void DeleteBrand(Brand brand);
    }
}
