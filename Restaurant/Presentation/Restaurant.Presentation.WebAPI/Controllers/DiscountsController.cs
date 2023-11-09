using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Core.Application.Dtos.Discount.Requests;
using Restaurant.Core.Application.Dtos.Discount;
using Restaurant.Core.Application.Services.DiscountService;

namespace Restaurant.Presentation.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountsController : ControllerBase
    {
        private readonly IDiscountService _discountService;

        public DiscountsController(IDiscountService discountService)
        {
            _discountService = discountService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var values = _discountService.TGetListAll();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var value = _discountService.TGetByID(id);
            return Ok(value);
        }
        [HttpPost]
        public IActionResult Create(CreateDiscountRequest createDiscountRequest)
        {
            _discountService.TAdd(createDiscountRequest);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update(GenericDiscountDto genericDiscountDto)
        {
            _discountService.TUpdate(genericDiscountDto);
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _discountService.TDelete(id);
            return Ok();
        }
    }
}
