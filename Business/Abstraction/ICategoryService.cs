using SmartPro.Core.Utilities.Result;
using SmartPro.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro.Business.Abstraction
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetCategories();
        IDataResult<Category> GetById(int id);
        IResult AddCategory(Category category);
        IResult Update(Category category);
        IResult Delete(Category category);



    }
}
