using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_ServiceCenter.ViewModels
{
    public class NewRoleFormViewModel
    {
        [Required]
        public string RoleName { get; set; }
    }
}
