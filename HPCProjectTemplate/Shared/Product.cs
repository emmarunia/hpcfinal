﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPCProjectTemplate.Shared
{
    public class Product
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string brand { get; set; }
        public double price { get; set; }


    }
}
