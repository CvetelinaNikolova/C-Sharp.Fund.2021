using System;
using System.Collections.Generic;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfStudents = double.Parse(Console.ReadLine());
            List<double> marks = new List<double>();
            double mark = 0;
            int topStudents = 0;
            int between4and499 = 0;
            int between3and399 = 0;
            int below3 = 0;
            double sumOfMarks = 0;
            for(int i= 1; i<=numberOfStudents; i++)
            {
               mark = double.Parse(Console.ReadLine());
                marks.Add(mark);
                sumOfMarks = sumOfMarks + mark;

            }
            foreach(double value in marks)
            {
                if(value >=5)
                {
                    topStudents++;
                }
                if ((value >= 4)&&(value<=4.99))
                {
                    between4and499++;
                }
                if ((value >= 3) && (value <= 3.99))
                {
                    between3and399++;
                }
                if (value < 3)
                {
                    below3++;
                }
            }
            double percentTopStudends = (topStudents *100) / numberOfStudents;
            double percent4To499 = (between4and499 * 100) / numberOfStudents;
            double percent3To399 = (between3and399 * 100) / numberOfStudents;
            double percentBelow3 = (below3 * 100) / numberOfStudents;
            double avarage = sumOfMarks / numberOfStudents;
            Console.WriteLine($"Top students: {percentTopStudends:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {percent4To499:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {percent3To399:f2}%");
            Console.WriteLine($"Fail: {percentBelow3:f2}%");
            Console.WriteLine($"Average: {avarage:f2}");
        }
    }
}
