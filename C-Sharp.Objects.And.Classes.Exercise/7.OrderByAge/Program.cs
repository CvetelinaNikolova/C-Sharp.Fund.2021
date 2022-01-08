using System;
using System.Collections.Generic;

namespace _7.OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Person> listOfPeople = new List<Person>();
            while (input!="End")
            {
                bool haveID = false;
                string[] personInfo = input.Split(' ');

                foreach (Person person1 in listOfPeople)
                {
                    if (personInfo[1]==person1.ID)
                    {
                        person1.Name = personInfo[0];
                        person1.Age = Convert.ToInt32(personInfo[2]);
                        haveID = true;
                    }
                }

                if (haveID!=true)
                {
                    Person person = new Person();
                    person.Name = personInfo[0];
                    person.ID = personInfo[1];
                    person.Age = Convert.ToInt32(personInfo[2]);
                    listOfPeople.Add(person);
                }

                input = Console.ReadLine();
            }

            Person[] arrPeople = listOfPeople.ToArray();

            Array.Sort(arrPeople, SortBy);
            foreach (Person person in arrPeople)
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
        public static int SortBy(Person person1, Person person2)
        {
            return person1.Age.CompareTo(person2.Age);
        }
    }
}
