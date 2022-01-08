using System;
using System.Collections.Generic;
using System.Text;

namespace _5._Shopping_Spree
{
    class Person
    {
        public string Name { get; set; }
        public decimal Money { get; set; }

        public List<Product> listOfBoughtProducts = new List<Product>();
    }
}
