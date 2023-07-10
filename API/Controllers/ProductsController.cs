using Microsoft.AspNetCore.Mvc;
using SmartPro.Business.Abstraction;
using SmartPro.Entities.Concrete;

namespace SmartPro.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    public class ProductsController : ControllerBase
    {
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet("getAll")]
        public IActionResult GetAll()
        {
            var products = _productService.GetAll();
            return Ok(products);
        }
        [HttpGet("getAllByCategory")]
        public IActionResult GetByCategoryId(int id)
        {
            var result = _productService.GetAllByCategoryId(id);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpGet("getById/{id}")]
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpGet("getByPrice/{min}-{max}")]
        public IActionResult GetByPrice(decimal min, decimal max=999999)
        {
            var result =_productService.GetByPrice(min, max);
            return Ok(result);
        }
        [HttpGet("getProductDetail")]
        public IActionResult GetProductDetail(int categoryId)
        {
            var result = _productService.GetProductDtos();
            return Ok(result);
        }
        [HttpPost("addProduct")]
        public IActionResult AddProduct(Product product)
        {
            var result = _productService.AddProduct(product);
            if( result.Success ) 
                return Ok(result);
            return BadRequest();
        }

        [HttpPut("updateProduct")]
        public IActionResult UpdateProduct(Product product)
        {
            var result = _productService.UpdateProduct(product);
            if ( result.Success )
                return Ok(result);
            return BadRequest();
        }
        [HttpDelete("deleteProduct")]
        public IActionResult DeleteProduct(Product product) 
        {
            var result = _productService.DeleteProduct(product);
            if (result.Success)
                return Ok(result);
            return BadRequest();
        }
    }
}
