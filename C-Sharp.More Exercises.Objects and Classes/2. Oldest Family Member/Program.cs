using System;

namespace _2._Oldest_Family_Member
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < countOfPeople; i++)
            {
                string[] newMember = Console.ReadLine().Split(' ');
                Person person = new Person();
                person.Name = newMember[0];
                person.Age = Convert.ToInt32(newMember[1]);
                family.AddMember(person);
            }
            Person oldestPerson = family.GetOldestMember();
            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");

        }

    }
}
