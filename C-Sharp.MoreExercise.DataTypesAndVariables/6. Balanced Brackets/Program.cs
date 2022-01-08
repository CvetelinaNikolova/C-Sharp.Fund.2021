using System;

namespace _6._Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            bool balanced = true;
            int count = 0;
            string lastInput = "";
            for (int i = 0; i < numberOfLines; i++)
            {
                string input = Console.ReadLine();
                
                if (count == 0 && input == ")")
                {
                    balanced = false;
                }

                if (input=="("||input==")")
                {
                    if (input=="("&&lastInput=="(")
                    {
                        balanced = false;
                    }
                    if (input==")"&&lastInput==")")
                    {
                        balanced = false;
                    }
                    lastInput = input;
                    count++;
                }
            }
            if (count%2!=0)
            {
                balanced = false;
            }
            if (balanced)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
