using System;
using System.Collections.Generic;
using System.Text;

namespace HW3_num2
{
    class Personlist
    {
        private List<Person> personList;

        public Personlist()
        {
            this.personList = new List<Person>();
        }

        public void AddNewPerson(Person person)
        {
            this.personList.Add(person);
        }
        public void FetchPersonList()
        {
            Console.WriteLine("List Persons");
            Console.WriteLine("-------------");
            foreach (Person person in this.personList)
            {
                if (person is Student)
                {
                    Console.WriteLine("Name : {0} \nType : Student", person.GetName());
                    Console.WriteLine("Activity Hour : {0}", person.GetActivityHour());
                    Console.WriteLine("\n------------------------------------------------\n");
                }
                else if (person is Teacher)
                {
                    Console.WriteLine("Name: {0} \nType: Teacher", person.GetName());
                    Console.WriteLine("\n------------------------------------------------\n");
                }
            }
        }
    }
}
