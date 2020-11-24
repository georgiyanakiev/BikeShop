using System;
using System.Collections.Generic;
using System.Data.Entity;
using BikeShop.Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeShop.Database
{
   public class BBContext : DbContext
    {
        public DbSet <Category> Categories { get; set; }
        public int MyProperty { get; set; }
    }
}
