using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class CustomerManager
    {
        public void ListCustomer(Customer[] customer)
        {
            foreach (Customer item in customer)
            {
                Console.WriteLine(item.Id + " => " + item.FirstName + " " + item.LastName + " => " + item.Mail + " => " + item.Phone + " => " + item.Country + " => " + item.City );
            }
        }

   
    }
}
