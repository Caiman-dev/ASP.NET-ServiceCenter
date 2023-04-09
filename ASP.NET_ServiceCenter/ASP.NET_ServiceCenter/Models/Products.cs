using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_ServiceCenter.Models
{
    public class Products
    {
        [Key]
        public int id { get; set; }

        [Required]
        public int cat_id { get; set; }

        [Required]
        public string serial { get; set; }

        [Required]
        [Range(0, 1000000)]
        public int price { get; set; }

        [RegularExpression("^\\d+$")]
        [StringLength(4)]
        public string year { get; set; }

        [Required]
        public string brand { get; set; }

        [Required]
        public string model { get; set; }
    }
}
