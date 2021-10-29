using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

using travel.Models.DB;

namespace travel.Models
{
    public class person
    {
        public int personId { get; set; }
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email is required")]
        public string email { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string password { get; set; }
        [Required(ErrorMessage = "Phone is required")]
        public string phone { get; set; }
        [Required(ErrorMessage = "Image is required")]
        public string image { get; set; }
        public int UserRoleId { get; set; }

        public virtual UserRole Role { get; set; }
        public virtual List<post> post { get; set; }
    }
}