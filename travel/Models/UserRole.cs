using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace travel.Models
{
    public class UserRole
    {
        public int UserRoleId { get; set; }
        public string Role { get; set; }
        public virtual List<person> person { get; set; }
    }
}