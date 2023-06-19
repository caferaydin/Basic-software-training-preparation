using SmartPro.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro.Business.Abstraction
{
    public interface ISubCategoryService
    {
        List<SubCategory> GetSubCategories();
        SubCategory GetById(int id);
        void AddSubCategory(SubCategory subCategory);

    }
}
