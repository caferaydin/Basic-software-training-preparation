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
            var subCategory = _subCategoryService.GetById(id);
            return Ok(subCategory.SubCategoryName);
        }
        [HttpPost("addSubCategory")]
        public IActionResult AddSubCategory(SubCategory subCategory)
        {
            _subCategoryService.AddSubCategory(subCategory);

            return Ok(subCategory.SubCategoryName);
        }
        [HttpPut("updateSubCategory")]
        public IActionResult UpdateSubCategory(SubCategory subCategory)
        {
            _subCategoryService.SubCategoryUpdate(subCategory);
            return Ok(subCategory.SubCategoryName);
        }
        [HttpDelete("deleteSubCategory")]
        public IActionResult DeleteSubCategory(SubCategory subCategory)
        {
            _subCategoryService.SubCategoryDelete(subCategory);
            return Ok(subCategory.SubCategoryName); 
        }
    }
}
