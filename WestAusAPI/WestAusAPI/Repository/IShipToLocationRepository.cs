using System.Collections.Generic;
using WestAusAPI.Model;

namespace WestAusAPI.Repository
{
    public interface IShipToLocationRepository
    {
        List<ShipToLocation> GetShipToLocations();

        ShipToLocation GetShipToLocation(int id);
        List<ShipToLocation> GetCustomerShipToLocations(int id);

        ShipToLocation AddShipToLocation(ShipToLocation shipToLocation);

        void DeleteShipToLocation(ShipToLocation shipToLocation);

        ShipToLocation EditShipToLocation(ShipToLocation shipToLocation);

    }
}
