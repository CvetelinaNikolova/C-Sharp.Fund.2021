using System;
using System.Collections.Generic;
namespace _5._Shopping_Spree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> listOfPeople = new List<Person>();

            List<Product> listOfProducts = new List<Product>();

            string[] people = Console.ReadLine().Split(';');
            for (int i = 0; i < people.Length; i++)
            {
                Person person = new Person();
                string[] personInfo = people[i].Split('=');
                person.Name = personInfo[0];
                person.Money = Convert.ToDecimal(personInfo[1]);
                listOfPeople.Add(person);
            }

            string[] products = Console.ReadLine().Split(';');
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i]==string.Empty)
                {
                    continue;
                }
                Product product = new Product();
                string[] productInfo = products[i].Split('=');
                product.Name = productInfo[0];
                product.Cost =Convert.ToDecimal(productInfo[1]);
                listOfProducts.Add(product);
            }

            string command = Console.ReadLine();
            while (command!="END")
            {
                string[] buyingProduct = command.Split(' ');
                foreach (Person person in listOfPeople)
                {
                    if (person.Name==buyingProduct[0])
                    {
                        foreach (Product product in listOfProducts)
                        {
                            if (product.Name==buyingProduct[1])
                            {
                                if (product.Cost>person.Money)
                                {
                                    Console.WriteLine($"{person.Name} can't afford {product.Name}");
                                }
                                else if (product.Cost<=person.Money)
                                {
                                    person.listOfBoughtProducts.Add(product);
                                    person.Money -= product.Cost;
                                    Console.WriteLine($"{person.Name} bought {product.Name}");
                                }
                            }
                        }
                    }
                }
                command = Console.ReadLine();
            }

            int countOfPeople = 0;
            foreach (Person person in listOfPeople)
            {
                if (person.listOfBoughtProducts.Count==0)
                {
                    if (countOfPeople>0)
                    {
                        Console.Write($"\n{person.Name} - Nothing bought");
                    }
                    else
                    {
                        Console.Write($"{person.Name} - Nothing bought");
                        countOfPeople++;
                    }
                }
                else
                {
                    if (countOfPeople>0)
                    {
                        Console.Write($"\n{person.Name} - ");
                        int productCount = 0;
                        foreach (Product product in person.listOfBoughtProducts)
                        {
                            if (productCount == 0)
                            {
                                Console.Write(product.Name);
                                productCount++;
                            }
                            else
                            {
                                Console.Write($", {product.Name}");
                            }
                        }
                    }
                    else
                    {
                        Console.Write($"{person.Name} - ");
                        int productCount = 0;
                        countOfPeople++;
                        foreach (Product product in person.listOfBoughtProducts)
                        {
                            if (productCount == 0)
                            {
                                Console.Write(product.Name);
                                productCount++;
                            }
                            else
                            {
                                Console.Write($", {product.Name}");
                            }
                        }
                    }
                }
            }
        }
    }

}
