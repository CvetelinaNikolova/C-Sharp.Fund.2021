using System;

namespace ConsoleApp1
{
    class Exercises3lessson
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the number you are going to turn to binary:");
            int nBinary = int.Parse(Console.ReadLine());
            Console.WriteLine("Write the position you are going to change:");
            int nPosition = int.Parse(Console.ReadLine());
            Console.WriteLine("Write into which number you are going to change:");
            int nOneOrZero = int.Parse(Console.ReadLine());
            if ((nOneOrZero == 1 ) || (nOneOrZero==0))
                    {
                return;
            }
            else
            {
                Console.WriteLine("The number needs to be one or zero!");
            }
            while ((nOneOrZero == 1) || (nOneOrZero == 0))
            {
                Console.WriteLine("Your number is recieved");
                break;
            }

        }
    }
}
