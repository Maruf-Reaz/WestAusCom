using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WestAusAPI.Model;

namespace WestAusAPI.Repository
{
    public interface ILocationRepository
    {
        List<Location> GetLocations();

        Location GetLocation(int id);
        List<Location> GetCustomerLocations(int id);

        Location AddLocation(Location location);

        void DeleteLocation(Location location);

        Location EditLocation(Location location);

    }
}
