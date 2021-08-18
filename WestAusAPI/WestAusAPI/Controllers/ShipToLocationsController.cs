using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WestAusAPI.Model;
using WestAusAPI.Service;

namespace WestAusAPI.Controllers
{
   
    [ApiController]
    public class ShipToLocationsController : ControllerBase
    {
        private readonly IShipToLocationService _shipToLocationService;
        public ShipToLocationsController(IShipToLocationService shipToLocationService)
        {
            _shipToLocationService = shipToLocationService;
        }
        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetShipToLocations()
        {

            return Ok(_shipToLocationService.GetShipToLocations());
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetShipToLocation(int id)
        {
            return Ok(_shipToLocationService.GetShipToLocation(id));
        }
        [HttpGet]
        [Route("api/[controller]/customer/{id}")]
        public IActionResult GetCustomerShipToLocations(int id)
        {
            return Ok(_shipToLocationService.GetCustomerShipToLocations(id));
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult AddShipToLocation(ShipToLocation shipToLocation)
        {
            _shipToLocationService.AddShipToLocation(shipToLocation);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Path + "/" + shipToLocation.Id, shipToLocation);
        }

        [HttpPatch]
        [Route("api/[controller]")]
        public IActionResult EditShipToLocation(ShipToLocation shipToLocation)
        {

            _shipToLocationService.EditShipToLocation(shipToLocation);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Path + "/" + shipToLocation.Id, shipToLocation);
        }

        [HttpDelete]
        [Route("api/[controller]")]
        public IActionResult DeleteShipToLocation(ShipToLocation shipToLocation)
        {

            _shipToLocationService.DeleteShipToLocation(shipToLocation);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Path + "/" + shipToLocation.Id, shipToLocation);
        }




    }
}
