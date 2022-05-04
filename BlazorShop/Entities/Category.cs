﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorShop.Entities
{
    public class Category
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
