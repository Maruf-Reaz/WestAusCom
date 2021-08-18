using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WestAusAPI.Data;
using WestAusAPI.Model;

namespace WestAusAPI.Repository
{
    public class ShipToLocationRepository : IShipToLocationRepository
    {

       
        private readonly ApplicationDbContext _context;

        public ShipToLocationRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<ShipToLocation> GetShipToLocations()
        {
            return _context.ShipToLocations.Include(m => m.Customer).ToList();
        }
        public ShipToLocation GetShipToLocation(int id)
        {
            return _context.ShipToLocations.Include(m => m.Customer).Where(m => m.Id == id).SingleOrDefault();
        }
        public List<ShipToLocation> GetCustomerShipToLocations(int id)
        {
            return _context.ShipToLocations.Include(m => m.Customer).Where(m => m.CustomerId == id).ToList();
        }

        public ShipToLocation AddShipToLocation(ShipToLocation shipToLocation)
        {
            _context.Add(shipToLocation);
            _context.SaveChanges();

            return shipToLocation;
        }

        public void DeleteShipToLocation(ShipToLocation shipToLocation)
        {

            _context.Remove(shipToLocation);
            _context.SaveChanges();
        }

        public ShipToLocation EditShipToLocation(ShipToLocation shipToLocation)
        {
            _context.Update(shipToLocation);
            _context.SaveChanges();
            return shipToLocation;
        }


    }
}
