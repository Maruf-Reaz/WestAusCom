using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WestAusAPI.Model;
using WestAusAPI.Repository;

namespace WestAusAPI.Service
{
    public class LocationService : ILocationService
    {
        private readonly ILocationRepository _locationRepository;
        public LocationService(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }

        public List<Location> GetLocations()
        {
            return _locationRepository.GetLocations();
        }
        public Location GetLocation(int id)
        {
            return _locationRepository.GetLocation(id);
        }
        public List<Location> GetCustomerLocations(int id)
        {
            return _locationRepository.GetCustomerLocations(id);
        }

        public Location AddLocation(Location location)
        {
            return _locationRepository.AddLocation(location);
        }

        public void DeleteLocation(Location location)
        {
            _locationRepository.DeleteLocation(location);
        }

        public Location EditLocation(Location location)
        {
            return _locationRepository.EditLocation(location);
        }



    }
}
