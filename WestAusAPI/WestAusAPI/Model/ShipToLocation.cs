using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WestAusAPI.Model
{
    public class ShipToLocation
    {
        public int Id { get; set; }
        [Required]
        public string LocationDetails { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }


    }
}
