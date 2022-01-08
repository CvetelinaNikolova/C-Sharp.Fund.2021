using System;
using System.Collections.Generic;

namespace _6._Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            List<Box> boxes = new List<Box>();
            while (input[0] != "end")
            {
                Item item = new Item();
                Box box = new Box();
                box.SerialNumber = input[0];
                box.Item.Name = input[1];
                box.ItemQuantity = Convert.ToInt32(input[2]);
                box.Item.Price = Convert.ToDecimal(input[3]);
                box.PriceForABox = box.PriceForBox(box.ItemQuantity, box.Item.Price);
                boxes.Add(box);
                input = Console.ReadLine().Split(' ');
            }
            Box[] newArr = boxes.ToArray();
            static int CompareNumber(Box box1, Box box2)
            {
                return box2.PriceForABox.CompareTo(box1.PriceForABox);
            }
            Array.Sort(newArr, CompareNumber);
            foreach (Box b in newArr)
            {
                Console.WriteLine($"{b.SerialNumber}\n-- {b.Item.Name} - ${b.Item.Price:f2}: {b.ItemQuantity}\n-- ${b.PriceForABox:f2}");
            }
        }
    }
}
