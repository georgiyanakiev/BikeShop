﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeShop.Entities
{
    public class Category : BaseEntity
    {
      public List<Product> Products { get; set; }
    }
}
