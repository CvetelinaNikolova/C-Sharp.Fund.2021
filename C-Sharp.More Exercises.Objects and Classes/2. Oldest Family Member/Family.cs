using System;
using System.Collections.Generic;
using System.Text;

namespace _2._Oldest_Family_Member
{
    class Family
    {
       public List<Person> familyMembers = new List<Person>();
        public void AddMember(Person member)
        {
            familyMembers.Add(member);
        }
        public Person GetOldestMember()
        {
            Person person = new Person();
            person.Age = int.MinValue;
            foreach (Person member in familyMembers)
            {
                if (member.Age>person.Age)
                {
                    person = member;
                }
            }
            return person;
        }
    }
}
