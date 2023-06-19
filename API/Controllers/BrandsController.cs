using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartPro.Business.Abstraction;
using SmartPro.Entities.Concrete;

namespace SmartPro.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        IBrandService _brandService;

        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            var brands = _brandService.GetBrands();
            return Ok(brands);
        }

        [HttpGet("getById/{id}")]
        public IActionResult Get(int id)
        {
            var result = _brandService.GetById(id);
            return Ok(result);
        }

        [HttpPost("addBrand")]
        public IActionResult Get(Brand brand)
        {
            _brandService.AddBrand(brand);
            return Ok(brand);
        }
    }
}
