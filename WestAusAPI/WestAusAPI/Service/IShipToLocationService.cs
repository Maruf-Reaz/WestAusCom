using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WestAusAPI.Model;

namespace WestAusAPI.Service
{
    public interface IShipToLocationService
    {
        List<ShipToLocation> GetShipToLocations();

        ShipToLocation GetShipToLocation(int id);
        List<ShipToLocation> GetCustomerShipToLocations(int id);

        ShipToLocation AddShipToLocation(ShipToLocation shipToLocation);

        void DeleteShipToLocation(ShipToLocation shipToLocation);

        ShipToLocation EditShipToLocation(ShipToLocation shipToLocation);

    }
}
