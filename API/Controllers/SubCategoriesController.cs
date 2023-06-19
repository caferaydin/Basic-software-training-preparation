using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartPro.Business.Abstraction;
using SmartPro.Entities.Concrete;

namespace SmartPro.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubCategoriesController : ControllerBase
    {
        ISubCategoryService _subCategoryService;

        public SubCategoriesController(ISubCategoryService subCategoryService)
        {
            _subCategoryService = subCategoryService;
        }

        [HttpGet("getAll")]
        public IActionResult GetAll() 
        {
            var sub = _subCategoryService.GetSubCategories();
            return Ok(sub);
        }
        [HttpGet("getById/{id}")]
        public IActionResult GetById(int id)
        { 
            var sub = _subCategoryService.GetById(id);
            return Ok(sub);
        }
        [HttpPost("AddSubCategory")]
        public IActionResult AddSubCategory(SubCategory subCategory)
        {
            _subCategoryService.AddSubCategory(subCategory);

            return Ok(subCategory);
        }
    }
}
