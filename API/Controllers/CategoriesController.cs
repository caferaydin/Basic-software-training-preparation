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

        [HttpGet]
        public IActionResult GetAll()
        {
            var categories = _categoryService.GetCategories();
            return Ok(categories);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var category = _categoryService.GetById(id);
            return Ok(category);
        }

        [HttpPost("AddCategory")]
        public IActionResult AddCategory(Category category)
        {
            _categoryService.AddCategory(category);

            return Ok(category);
        }
    }
}
