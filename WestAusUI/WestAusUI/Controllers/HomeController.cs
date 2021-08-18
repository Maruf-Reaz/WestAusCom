using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WestAusUI.Controllers
{

    public class HomeController : Controller
    {
        public HomeController()
        {


        }
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult CustomerIndex()
        {
            return View();
        }
        public IActionResult EditCustomer(int customerId)
        {
            ViewData["CustomerId"] = customerId;
            return View();
        }

        public IActionResult CreateCustomer()
        {
            return View();
        }
        public IActionResult LocationIndex(int customerId)
        {
            ViewData["CustomerId"] = customerId;
            return View();
        }

        public IActionResult EditLocation(int locationId, int customerId)
        {
            ViewData["LocationId"] = locationId;
            ViewData["CustomerId"] = customerId;
            return View();
        }

        public IActionResult CreateLocation(int customerId)
        {
            ViewData["CustomerId"] = customerId;
            return View();
        }

        public IActionResult ShipToLocationIndex(int customerId)
        {
            ViewData["CustomerId"] = customerId;
            return View();
        }

        public IActionResult EditShipToLocation(int locationId, int customerId)
        {
            ViewData["ShipToLocationId"] = locationId;
            ViewData["CustomerId"] = customerId;
            return View();
        }

        public IActionResult CreateShipToLocation(int customerId)
        {
            ViewData["CustomerId"] = customerId;
            return View();
        }

        public IActionResult ContactIndex(int customerId)
        {
            ViewData["CustomerId"] = customerId;
            return View();
        }
        public IActionResult EditContact(int contactId, int customerId)
        {
            ViewData["ContactId"] = contactId;
            ViewData["CustomerId"] = customerId;
            return View();
        }

        public IActionResult CreateContact(int customerId)
        {
            ViewData["CustomerId"] = customerId;
            return View();
        }



    }
}
