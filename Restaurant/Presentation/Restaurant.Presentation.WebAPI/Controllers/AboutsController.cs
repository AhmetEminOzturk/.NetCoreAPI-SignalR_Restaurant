using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Core.Application.Dtos.About;
using Restaurant.Core.Application.Dtos.About.Requests;
using Restaurant.Core.Application.Services.AboutService;

namespace Restaurant.Presentation.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController : ControllerBase
    {
        private readonly IAboutService _aboutService;

        public AboutsController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var values = _aboutService.TGetListAll();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var value = _aboutService.TGetByID(id);
            return Ok(value);
        }
        [HttpPost]
        public IActionResult Create(CreateAboutRequest createAboutRequest)
        {
            _aboutService.TAdd(createAboutRequest);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update(GenericAboutDto genericAboutDto)
        {
            _aboutService.TUpdate(genericAboutDto);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _aboutService.TDelete(id);
            return Ok();
        }
    }
}
