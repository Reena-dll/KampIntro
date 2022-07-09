using System;

namespace Constructors
{
    class Program
    {
        // Bir sınıfı new'lediğimizde direkt çalışan kod bloğu.
        static void Main(string[] args)
        {
            Customer customer = new Customer
            { Id = 1, FirstName = "Engin",
                LastName = "Demiroğ",
                City = "Ankara" };
            Customer customer2 = new Customer(2,"Derin","Demiroğ","Ankara");

            Customer customer3 = new Customer();
            customer3.Id = 3;

            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();
            
        }
    }

    class Customer
    {
        // Default Constructor
        public Customer()
        {

        }
       
        public Customer(int id, string firstName, string lastName, string city)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
