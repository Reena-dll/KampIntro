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
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1999, 10, 13), FirstName = "Oğuzhan", LastName = "Sadıkoğlu", NationaltyId = "321321321" });

        }
    }
}
