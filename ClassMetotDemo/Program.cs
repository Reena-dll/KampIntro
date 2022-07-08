using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Oğuzhan";
            customer1.LastName = "Sadıkoğlu";
            customer1.Mail = "ouz.spy@gmail.com";
            customer1.Phone = "541 935 99 99";
            customer1.Country = "Turkey";
            customer1.City = "İstanbul";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Ahmet";
            customer2.LastName = "Sadıkoğlu";
            customer2.Mail = "ahmet.sadikoglu@gmail.com";
            customer2.Phone = "541 321 99 99";
            customer2.Country = "Turkey";
            customer2.City = "İstanbul";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Resul";
            customer3.LastName = "Sadıkoğlu";
            customer3.Mail = "resul.sadikoglu@gmail.com";
            customer3.Phone = "541 123 99 99";
            customer3.Country = "Turkey";
            customer3.City = "İstanbul";

            Customer customer4 = new Customer();
            customer4.Id = 4;
            customer4.FirstName = "Ludwig";
            customer4.LastName = "Kros";
            customer4.Mail = "ludwigkros@outlook.com";
            customer4.Phone = "541 555 99 99";
            customer4.Country = "Germany";
            customer4.City = "Berlin";

            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.ListCustomer(customers);
            



            Console.ReadLine();
        }
    }
}
