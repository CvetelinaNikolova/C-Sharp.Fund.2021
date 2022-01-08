using System;
using System.Collections.Generic;
using System.Linq;
namespace _4._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<decimal, decimal>> productList = new Dictionary<string, Dictionary<decimal, decimal>>();

            string command = Console.ReadLine();
            while (command!="buy")
            {
                string[] productInfo = command.Split(' ');
                string name = productInfo[0];
                decimal price = Convert.ToDecimal(productInfo[1]);
                decimal quantity = Convert.ToDecimal(productInfo[2]);
                if (!productList.ContainsKey(name))
                {
                    Dictionary<decimal, decimal> priceAndQuantity = new Dictionary<decimal, decimal>()
                    {
                        { price, quantity}
                    };
                    productList.Add(name, priceAndQuantity);
                }
                else
                {
                    decimal currentPrice = productList[name].Keys.ElementAt(0);
                    if (!productList[name].ContainsKey(price))
                    {
                        decimal currentQuantity = productList[name][currentPrice];
                        productList[name].Clear();
                        Dictionary<decimal, decimal> newDic = new Dictionary<decimal, decimal>()
                        {
                            { price, currentQuantity+quantity }
                        };
                        productList[name] = newDic;
                    }
                    else if (productList[name].ContainsKey(price))
                    {
                        productList[name][price] += quantity;
                    }
                }
                command = Console.ReadLine();
            }

            foreach (var pair in productList)
            {
                decimal price = productList[pair.Key].Keys.ElementAt(0);
                decimal quantity = productList[pair.Key][price];
                decimal finalPrice = price * quantity;
                Console.WriteLine($"{pair.Key} -> {finalPrice:f2}");
            }

        }
    }
}
