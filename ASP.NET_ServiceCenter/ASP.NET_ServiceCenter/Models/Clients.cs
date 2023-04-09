using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_ServiceCenter.Models
{
    public class Clients
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Please enter a passport number")]
        public string passport { get; set; }

        [Required(ErrorMessage = "Please enter a name")]
        public string name { get; set; }

        [Required(ErrorMessage = "Please enter an address")]
        public string address { get; set; }

        [Required(ErrorMessage = "Please enter a phone number")]
        public string phone { get; set; }

        [DataType(DataType.Date)]
        public DateTime birthdate { get; set; }
    }
}
