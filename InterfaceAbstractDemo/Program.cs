using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using InterfaceAbstractDemo.Adapters;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1997, 10, 13), FirstName = "Oğuzhan", LastName = "Sadıkoğlu", NationaltyId = "62068228598" });
            Console.ReadLine();

        }
    }
}
