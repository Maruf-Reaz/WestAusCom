using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WestAusAPI.Model;
using WestAusAPI.Service;

namespace WestAusAPI.Controllers
{
   
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly ILocationService _locationService;
        public LocationsController(ILocationService locationService)
        {
            _locationService = locationService;
        }
        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetLocations()
        {
            return Ok(_locationService.GetLocations());
        }

        [HttpGet]
        [Route("api/[controller]/customer/{id}")]
        public IActionResult GetCustomerLocations(int id)
        {
            return Ok(_locationService.GetCustomerLocations(id));
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetLocation(int id)
        {
            return Ok(_locationService.GetLocation(id));
        }
        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult AddLocation(Location location)
        {
            _locationService.AddLocation(location);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Path + "/" + location.Id, location);
        }

        [HttpPatch]
        [Route("api/[controller]")]
        public IActionResult EditLocation(Location location)
        {

            _locationService.EditLocation(location);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Path + "/" + location.Id, location);
        }

        [HttpDelete]
        [Route("api/[controller]")]
        public IActionResult DeleteLocation(Location location)
        {

            _locationService.DeleteLocation(location);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Path + "/" + location.Id, location);
        }




    }
}
