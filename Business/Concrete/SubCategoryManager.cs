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
    public class SubCategoryManager : ISubCategoryService
    {
        ISubCategoryDal _subCategory;

        public SubCategoryManager(ISubCategoryDal subCategory)
        {
            _subCategory = subCategory;
        }

        public void AddSubCategory(SubCategory subCategory)
        {
            _subCategory.Add(subCategory);
        }

        public SubCategory GetById(int id)
        {
            return _subCategory.Get(p=>p.Id == id);
        }

        public List<SubCategory> GetSubCategories()
        {
            return _subCategory.GetAll();
        }
    }
}
