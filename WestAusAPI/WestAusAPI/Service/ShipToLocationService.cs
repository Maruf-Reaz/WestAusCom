using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WestAusAPI.Model;
using WestAusAPI.Repository;

namespace WestAusAPI.Service
{

    public class ShipToLocationService : IShipToLocationService
    {
        private readonly IShipToLocationRepository _shipToLocationRepository;
        public ShipToLocationService(IShipToLocationRepository shipToLocationRepository)
        {
            _shipToLocationRepository = shipToLocationRepository;
        }

        public List<ShipToLocation> GetShipToLocations()
        {
            return _shipToLocationRepository.GetShipToLocations();
        }
        public ShipToLocation GetShipToLocation(int id)
        {
            return _shipToLocationRepository.GetShipToLocation(id);
        }
         public List<ShipToLocation> GetCustomerShipToLocations(int id)
        {
            return _shipToLocationRepository.GetCustomerShipToLocations(id);
        }

        public ShipToLocation AddShipToLocation(ShipToLocation shipToLocation)
        {
            return _shipToLocationRepository.AddShipToLocation(shipToLocation);
        }

        public void DeleteShipToLocation(ShipToLocation shipToLocation)
        {
            _shipToLocationRepository.DeleteShipToLocation(shipToLocation);
        }

        public ShipToLocation EditShipToLocation(ShipToLocation shipToLocation)
        {
            return _shipToLocationRepository.EditShipToLocation(shipToLocation);
        }



    }

   
}
