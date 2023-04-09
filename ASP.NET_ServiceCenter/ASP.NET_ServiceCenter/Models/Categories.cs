using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_ServiceCenter.Models
{
    public class Categories
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string cat_name { get; set; }

        public string cat_description { get; set; }
    }
}
