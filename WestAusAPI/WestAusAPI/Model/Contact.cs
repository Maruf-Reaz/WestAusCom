using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WestAusAPI.Model
{
    public class Contact
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [Required]
        public string CellPhoneNumber { get; set; }
        [Required]
        public string TelePhoneNumber { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
