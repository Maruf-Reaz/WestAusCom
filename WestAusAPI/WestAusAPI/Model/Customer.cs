using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WestAusAPI.Model
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        public List<Location> Locations { get; set; }
        public List<ShipToLocation> ShipToLocations { get; set; }
        public List<Contact> Contacts { get; set; }

    }
}
