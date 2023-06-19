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
        void AddBrand(Brand category);
        void Update(Brand category);
        void Delete(Brand brand);
    }
}
