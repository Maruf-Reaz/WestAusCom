using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WestAusAPI.Data;
using WestAusAPI.Model;

namespace WestAusAPI.Repository
{
    public class LocationRepository : ILocationRepository
    {

       
        private readonly ApplicationDbContext _context;

        public LocationRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<Location> GetLocations()
        {
            return _context.Locations.Include(m => m.Customer).ToList();
        }
        public Location GetLocation(int id)
        {
            return _context.Locations.Include(m=>m.Customer).Where(m=>m.Id==id).SingleOrDefault();
        }
         public List<Location> GetCustomerLocations(int id)
        {
            return _context.Locations.Include(m=>m.Customer).Where(m=>m.CustomerId==id).ToList();
        }

        public Location AddLocation(Location location)
        {
            _context.Add(location);
            _context.SaveChanges();

            return location;
        }

        public void DeleteLocation(Location location)
        {

            _context.Remove(location);
            _context.SaveChanges();
        }

        public Location EditLocation(Location location)
        {
            _context.Update(location);
            _context.SaveChanges();
            return location;
        }


    }
}
