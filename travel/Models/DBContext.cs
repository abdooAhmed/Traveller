using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using travel.Models;
namespace travel.Models
{
    public class DBContext : DbContext
    {
        public DbSet<person> Persons { get; set; }
        public DbSet<UserRole> Roles { get; set; }
    }
}