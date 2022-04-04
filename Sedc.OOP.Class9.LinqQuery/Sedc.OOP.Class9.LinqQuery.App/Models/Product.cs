using System;
using System.Collections.Generic;
using System.Text;

namespace Sedc.OOP.Class9.LinqQuery.App.Models
{
    public class Product
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public int Price { get; set; }
        public Category Category { get; set; }  
    }
}
