using System;
using System.Collections.Generic;

namespace _2.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
             string[]stringNumbers = Console.ReadLine().Split(' ');


            List<string> listStrNames = new List<string>();
            foreach (string str in stringNumbers)
            {
                listStrNames.Add(str);
            }


            string[] operation = Console.ReadLine().Split(' ');

            while (operation[0] != "Finish")
            {

                if (operation[0] == "Add")
                {
                    listStrNames.Add(operation[1]);
                }
                else if (operation[0] == "Remove")
                {
                    for (int i = 0; i < listStrNames.Count; i++)
                    {
                        if (operation[1] == listStrNames[i])
                        {
                            listStrNames.Remove(listStrNames[i]);
                            break;
                        }
                    }
                }
                else if (operation[0] == "Replace")
                {
                    for (int i = 0; i < listStrNames.Count; i++)
                    {
                        if (operation[1] == listStrNames[i])
                        {
                            listStrNames[i] = operation[2];
                            break;
                        }
                    }
                }
                else if (operation[0] == "Collapse")
                {
                    List<int> intNumbers = new List<int>();
                    for (int i = 0; i < listStrNames.Count; i++)
                    {
                        intNumbers.Add(Convert.ToInt32(listStrNames[i]));
                    }

                    int value = Convert.ToInt32(operation[1]);

                    foreach (int num in intNumbers)
                    {
                        if (value>num)
                        {
                            listStrNames.Remove(Convert.ToString(num));
                        }
                    }
                }
                operation = Console.ReadLine().Split(' ');
            }
            foreach (string str in listStrNames)
            {
                Console.Write($"{str} ");
            }
        }
    }
}
