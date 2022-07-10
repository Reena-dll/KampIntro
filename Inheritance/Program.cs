using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>()
            {
                new Customer{FirstName="Oğuzhan"},
                new Student{FirstName ="Derin" },
                new Person{FirstName = "Salih"}
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }


            Console.ReadLine();
            
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

 // Bir nesne birden fazla interface alabilir amaaaa
 // birden fazla inheritance ( kalıtım ) alamaz!!!!!

    class Customer : Person
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Departman { get; set; }
    }
}
