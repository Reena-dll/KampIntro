using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> weekdays = new Dictionary<int, string>(); // Bu yağtımız Dictionary'i kendimiz sınıflayalım :p
            weekdays.Add(1, "Pazartesi");
            weekdays.Add(2, "Salı");
            weekdays.Add(3, "Çarşamba");
            weekdays.Add(4, "Perşembe");
            weekdays.Add(5, "Cuma");
            weekdays.Add(6, "Cumartesi");
            weekdays.Add(7, "Pazar");
            Console.WriteLine("Toplam Gün Sayısı: "+ weekdays.Count);
            foreach (var item in weekdays)
            {
                Console.WriteLine("{0}.Gün = {1}", item.Key, item.Value);
            }

            Console.WriteLine("MyDictionary-------------");
            MyDictionary<int, string> weekdays2 = new MyDictionary<int, string>();
            weekdays2.Add(1, "Pazartesi");
            weekdays2.Add(2, "Pazartesi");
            weekdays2.Add(3, "Pazartesi");
            weekdays2.Add(4, "Pazartesi");
            weekdays2.Add(5, "Pazartesi");
            weekdays2.Add(6, "Pazartesi");
            weekdays2.Add(7, "Pazartesi");
            Console.WriteLine("Toplam Gün Sayısı: "+weekdays2.Length);
            foreach (var item in weekdays2.Items)
            {
                Console.WriteLine("{0}.Gün = {1}", item);
            }



            Console.ReadLine();
        }
    }
}
