﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebShop_Random.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}