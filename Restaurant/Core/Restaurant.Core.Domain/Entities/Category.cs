﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public bool Status { get; set; }
        public List<Product> Products { get; set; }
    }
}
