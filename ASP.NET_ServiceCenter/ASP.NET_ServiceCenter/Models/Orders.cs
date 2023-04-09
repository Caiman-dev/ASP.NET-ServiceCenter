using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_ServiceCenter.Models
{
    public class Orders
    {
        [Key]
        public int id { get; set; }

        [Required]
        public int product_id { get; set; }

        [Required]
        public string user_id { get; set; }

        [Required]
        public string user_name { get; set; }

        [Required]
        public int client_id { get; set; }

        [DataType(DataType.Date)]
        public DateTime date_start { get; set; }

        [DataType(DataType.Date)]
        public DateTime date_end { get; set; }

        [Required]
        [Range(0, 10000)]
        public int price { get; set; }
    }
}
