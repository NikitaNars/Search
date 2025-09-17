using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Product
    {
        public string name { get; set; }
        public double price { get; set; }
        public Product(string name, double prisce) 
        {
            this.name = name;
            this.price = prisce;
        }
        
    }

}
