using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Core.Application.Dtos.Contact.Requests;
using Restaurant.Core.Application.Dtos.Contact;
using Restaurant.Core.Application.Services.ContactService;

namespace Restaurant.Presentation.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactsController(IContactService contactService)
        {
            _contactService = contactService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var values = _contactService.TGetListAll();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var value = _contactService.TGetByID(id);
            return Ok(value);
        }
        [HttpPost]
        public IActionResult Create(CreateContactRequest createContactRequest)
        {
            _contactService.TAdd(createContactRequest);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update(GenericContactDto genericContactDto)
        {
            _contactService.TUpdate(genericContactDto);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _contactService.TDelete(id);
            return Ok();
        }
    }
}
