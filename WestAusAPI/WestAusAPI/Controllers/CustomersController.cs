using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WestAusAPI.Model;
using WestAusAPI.Service;

namespace WestAusAPI.Controllers
{
   
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetCustomers()
        {
            return Ok(_customerService.GetCustomers());
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetCustomer(int id)
        {
            return Ok(_customerService.GetCustomer(id));
        }




        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult AddCustomer(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _customerService.AddCustomer(customer);
                return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Path + "/" + customer.Id, customer);
            }
            return NotFound();

            
        }

        [HttpPatch]
        [Route("api/[controller]")]
        public IActionResult EditCustomer(Customer customer)
        {

            if (ModelState.IsValid)
            {
                _customerService.EditCustomer(customer);
                return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Path + "/" + customer.Id, customer);
            }
            return NotFound();
        }

        [HttpDelete]
        [Route("api/[controller]")]
        public IActionResult DeleteCustomer(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _customerService.DeleteCustomer(customer);
                return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Path + "/" + customer.Id, customer);
            }
            return NotFound();

         
        }




    }
}
