using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Core.Application.Dtos.Feature.Requests;
using Restaurant.Core.Application.Dtos.Feature;
using Restaurant.Core.Application.Services.FeatureService;

namespace Restaurant.Presentation.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeaturesController : ControllerBase
    {
        private readonly IFeatureService _featureService;

        public FeaturesController(IFeatureService featureService)
        {
            _featureService = featureService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var values = _featureService.TGetListAll();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var value = _featureService.TGetByID(id);
            return Ok(value);
        }
        [HttpPost]
        public IActionResult Create(CreateFeatureRequest createFeatureRequest)
        {
            _featureService.TAdd(createFeatureRequest);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update(GenericFeatureDto genericFeatureDto)
        {
            _featureService.TUpdate(genericFeatureDto);
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _featureService.TDelete(id);
            return Ok();
        }
    }
}
