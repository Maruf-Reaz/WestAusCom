using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WestAusAPI.Model;

namespace WestAusAPI.Service
{
    public interface ILocationService
    {
        List<Location> GetLocations();

        Location GetLocation(int id);
        List<Location> GetCustomerLocations(int id);

        Location AddLocation(Location location);

        void DeleteLocation(Location location);

        Location EditLocation(Location location);

    }
}
