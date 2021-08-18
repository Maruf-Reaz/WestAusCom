using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WestAusAPI.Model;
using WestAusAPI.Service;

namespace WestAusAPI.Controllers
{
   
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactService _contactService;
        public ContactsController(IContactService contactService)
        {
            _contactService = contactService;
        }
        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetContacts()
        {
            return Ok(_contactService.GetContacts());
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetContact(int id)
        {
            return Ok(_contactService.GetContact(id));
        }
        [HttpGet]
        [Route("api/[controller]/customer/{id}")]
        public IActionResult GetCustomerContact(int id)
        {
            return Ok(_contactService.GetCustomerContact(id));
        }




        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult AddContact(Contact contact)
        {
            if (ModelState.IsValid)
            {
                _contactService.AddContact(contact);
                return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Path + "/" + contact.Id, contact);
            }
            return NotFound();
        }

        [HttpPatch]
        [Route("api/[controller]")]
        public IActionResult EditContact(Contact contact)
        {
            if (ModelState.IsValid)
            {
                _contactService.EditContact(contact);
                return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Path + "/" + contact.Id, contact);
            }
            return NotFound();
            
        }

        [HttpDelete]
        [Route("api/[controller]")]
        public IActionResult DeleteContact(Contact contact)
        {
            if (ModelState.IsValid)
            {
                _contactService.DeleteContact(contact);
                return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Path + "/" + contact.Id, contact);
            }
            return NotFound();
           
        }




    }
}
