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

        [HttpGet("getAll")]
        public IActionResult GetAll()
        {
            var brands = _brandService.GetBrands();
            return Ok(brands);
        }

        [HttpGet("getById/{id}")]
        public IActionResult GetById(int id)
        {
            var result = _brandService.GetById(id);
            return Ok(result.BrandName);
        }

        [HttpPost("addBrand")]
        public IActionResult AddBrand(Brand brand)
        {
            _brandService.AddBrand(brand);
            return Ok(brand.BrandName);
        }
        [HttpPut("updateBrand")]
        public IActionResult UpdateBrand(Brand brand)
        {
            _brandService.UpdateBrand(brand);
            return Ok(brand.BrandName);
        }
        [HttpDelete("deleteBrand")]
        public IActionResult DeleteBrand(Brand brand) 
        {
            _brandService.DeleteBrand(brand);
            return Ok(brand.BrandName);
        }
    }
}
