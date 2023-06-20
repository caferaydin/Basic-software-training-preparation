using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartPro.Business.Abstraction;
using SmartPro.Entities.Concrete;

namespace SmartPro.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("getAll")]
        public IActionResult GetCategories()
        {
            var categories = _categoryService.GetCategories();
            return Ok(categories);
        }
        [HttpGet("getById/{id}")]
        public IActionResult GetById(int id)
        {
            var category = _categoryService.GetById(id);
            return Ok(category);
        }

        [HttpPost("addCategory")]
        public IActionResult AddCategory(Category category)
        {
            _categoryService.AddCategory(category);

            return Ok(category);
        }

        [HttpPut("updateCategory/{id}")]
        public IActionResult updateCategory(Category category, int id)
        {
            _categoryService.Update(category);
            return Ok(category);
        }

        [HttpDelete("deleteCategory")]
        public IActionResult DeleteCategory(Category category)
        {
            _categoryService.Delete(category);
            return Ok(category);
        }
    }
}
