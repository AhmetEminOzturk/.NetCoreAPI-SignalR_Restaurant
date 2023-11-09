using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Core.Application.Dtos.Product.Requests;
using Restaurant.Core.Application.Dtos.Product;
using Restaurant.Core.Application.Services.ProductService;

namespace Restaurant.Presentation.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var values = _productService.TGetListAll();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var value = _productService.TGetByID(id);
            return Ok(value);
        }
        [HttpPost]
        public IActionResult Create(CreateProductRequest createProductRequest)
        {
            _productService.TAdd(createProductRequest);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update(GenericProductDto genericProductDto)
        {
            _productService.TUpdate(genericProductDto);
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _productService.TDelete(id);
            return Ok();
        }
    }
}
