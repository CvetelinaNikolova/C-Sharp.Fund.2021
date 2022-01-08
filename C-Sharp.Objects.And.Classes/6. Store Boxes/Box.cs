using System;
using System.Collections.Generic;
using System.Text;

namespace _6._Store_Boxes
{
    class Box
    {
        public Box()
        {
            Item = new Item();
        }
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PriceForBox(int Quantity, decimal Price)
        {
            return Quantity * Price;
        }
        public decimal PriceForABox { get; set; }
    }
}
