using System;

namespace _3.Floating_Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal doubleNumber1 = decimal.Parse(Console.ReadLine());
            decimal doubleNumber2 = decimal.Parse(Console.ReadLine());
            

            decimal result =Math.Abs(doubleNumber1-doubleNumber2);
            

            bool equal = true;
            if (result>=(decimal)0.000001)
            {
                equal = false;
            }
            Console.WriteLine(equal);
        }
    }
}
