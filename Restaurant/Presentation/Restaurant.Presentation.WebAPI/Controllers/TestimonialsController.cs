using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Core.Application.Dtos.Testimonial.Requests;
using Restaurant.Core.Application.Dtos.Testimonial;
using Restaurant.Core.Application.Services.TestimonialService;

namespace Restaurant.Presentation.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialsController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var values = _testimonialService.TGetListAll();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var value = _testimonialService.TGetByID(id);
            return Ok(value);
        }
        [HttpPost]
        public IActionResult Create(CreateTestimonialRequest createTestimonialRequest)
        {
            _testimonialService.TAdd(createTestimonialRequest);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update(GenericTestimonialDto genericTestimonialDto)
        {
            _testimonialService.TUpdate(genericTestimonialDto);
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _testimonialService.TDelete(id);
            return Ok();
        }
    }
}
