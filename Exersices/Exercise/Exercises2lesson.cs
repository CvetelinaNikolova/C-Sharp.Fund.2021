using System;

namespace Exercise
{
    class Exercises2lesson
    {
        static void Main(string[] args)
        {
            byte a, b, c;
            a = 97;
            b = 224;
            c = 114;
            sbyte d, e;
            d = -114;
            e = -44;
            ulong f = 123456789123456789l;
            float g = 12.345f;
            decimal ab = 0.000001m;
            decimal abc = 0.000001m;
            decimal theSum = ab + abc;
            Console.WriteLine(theSum);
            int hex = 0x100;
            Console.WriteLine(hex);
            
            
            
            char bay = '\u0072';
            Console.WriteLine(bay);
            
            
            
            bool isMale = false;
            
            
            
            string word1 = "Hello";
            string word2 = "World";
            object word3 = word1 + " " + word2;
            Console.WriteLine(word3);
            string word4 = (string)word3;
            Console.WriteLine(word4);
            
            
            
            string quotas = "The \"use\" of quotas ";
            string quotas1 = @"The ""use"" of quotas";
            Console.WriteLine(quotas + "    " + quotas1);
            
            
            
            Console.WriteLine(@"
              OOOOO    OOOOO
            OO    OOOOOO    OO
             OO    OOOO    OO
               OO   OO    OO
                 OO  O   OO
                   OOOOO");
           
            
            
            Console.WriteLine("       \u263A" +
                "\n     \u263A   \u263A" +
                "\n    \u263A     \u263A" +
                "\n    \u263A\u263A\u263A\u263A\u263A\u263A\u263A");



            Console.Write("First name:");
            string firstName = Console.ReadLine();
            Console.Write("Last name:");
            string lastName = Console.ReadLine();
            Console.Write("Sex(M/F):");
            char sex = char.Parse(Console.ReadLine());
            Console.Write("Your unique number:");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} {1}, {2}, {3}", firstName, lastName, sex, number);



            int one = 5;
            int two = 10;
            int three;
            three = one;
            one = two;
            two = three;
            Console.WriteLine("{0}, {1} ",one, two);

        }
    }
}
