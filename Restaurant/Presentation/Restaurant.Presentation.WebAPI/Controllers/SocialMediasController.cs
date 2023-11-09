using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Core.Application.Dtos.SocialMedia.Requests;
using Restaurant.Core.Application.Dtos.SocialMedia;
using Restaurant.Core.Application.Services.SocialMediaService;

namespace Restaurant.Presentation.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediasController : ControllerBase
    {
        private readonly ISocialMediaService _socialMediaService;

        public SocialMediasController(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var values = _socialMediaService.TGetListAll();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var value = _socialMediaService.TGetByID(id);
            return Ok(value);
        }
        [HttpPost]
        public IActionResult Create(CreateSocialMediaRequest createSocialMediaRequest)
        {
            _socialMediaService.TAdd(createSocialMediaRequest);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update(GenericSocialMediaDto genericSocialMediaDto)
        {
            _socialMediaService.TUpdate(genericSocialMediaDto);
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _socialMediaService.TDelete(id);
            return Ok();
        }
    }
}
