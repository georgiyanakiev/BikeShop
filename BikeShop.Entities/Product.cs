using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeShop.Entities
{
    public class Product : BaseEntity
    {
        public Category Category { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

    }
}
