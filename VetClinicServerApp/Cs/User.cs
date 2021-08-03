using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace VetClinicServerApp
{
    class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class UserContext : DbContext
    {
        public UserContext()
            :base("Dbconnection")
        { }

        public DbSet<User> Users { get; set; }
    }

}
