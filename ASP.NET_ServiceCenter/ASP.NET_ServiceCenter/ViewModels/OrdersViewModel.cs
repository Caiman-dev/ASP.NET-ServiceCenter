using ASP.NET_ServiceCenter.Areas.Identity.Data;
using ASP.NET_ServiceCenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_ServiceCenter.ViewModels
{
    public class OrdersViewModel
    {
        public IEnumerable<Orders> Orders { get; set; }
        public IEnumerable<ApplicationUser> Masters { get; set; }
    }
}
