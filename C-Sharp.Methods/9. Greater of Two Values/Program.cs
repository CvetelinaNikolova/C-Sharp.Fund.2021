using System;

namespace _9._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string value1 = Console.ReadLine();
            string value2 = Console.ReadLine();
            GetMax(type, value1, value2);
        }
        static void GetMax(string type, string value1, string value2)
        {

            if (type=="int")
            {
                int val1 = Convert.ToInt32(value1);
                int val2 = Convert.ToInt32(value2);
                if (val1>=val2)
                {
                    Console.WriteLine(value1);
                }
                else if (val2>val1)
                {
                    Console.WriteLine(value2);
                }
            }
            else if (type=="char")
            {
                char val1 = Convert.ToChar(value1);
                char val2= Convert.ToChar(value2);
                if (val1 >= val2)
                {
                    Console.WriteLine(value1);
                }
                else if (val2>val1)
                {
                    Console.WriteLine(value2);
                }
            }
            else if (type=="string")
            {
                int result = String.CompareOrdinal(value1, value2);
                if (result<0)
                {
                    Console.WriteLine(value2);
                }
                else
                {
                    Console.WriteLine(value1);
                }
            }
        }
    }
}
