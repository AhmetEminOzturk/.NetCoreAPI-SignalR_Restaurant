using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Core.Application.Dtos.Category.Requests;
using Restaurant.Core.Application.Dtos.Category;
using Restaurant.Core.Application.Services.CategoryService;

namespace Restaurant.Presentation.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var values = _categoryService.TGetListAll();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var value = _categoryService.TGetByID(id);
            return Ok(value);
        }
        [HttpPost]
        public IActionResult Create(CreateCategoryRequest createCategoryRequest)
        {
            _categoryService.TAdd(createCategoryRequest);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update(GenericCategoryDto genericCategoryDto)
        {
            _categoryService.TUpdate(genericCategoryDto);
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _categoryService.TDelete(id);
            return Ok();
        }
    }
}
