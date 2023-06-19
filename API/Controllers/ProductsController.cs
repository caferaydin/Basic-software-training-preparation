using Microsoft.AspNetCore.Http;
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
        [HttpGet("getAllByCategory/{id}")]
        public IActionResult GetByCategoryId(int id)
        {
            var result = _productService.GetAllByCategoryId(id);
            return Ok(result);
        }
        [HttpGet("getById/{id}")]
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            return Ok(result);
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
            _productService.AddProduct(product);
            return Ok(product);
        }

        [HttpPut("updateProduct")]
        public IActionResult UpdateProduct(Product product)
        {
            _productService.UpdateProduct(product);
            return Ok(product);
        }
        [HttpDelete("deleteProduct")]
        public IActionResult DeleteProduct(Product product) 
        {
            _productService.DeleteProduct(product);
            return Ok(product);
        }
    }
}
