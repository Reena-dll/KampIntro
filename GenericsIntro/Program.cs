using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İsimler List");
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Engin");
            Console.WriteLine(isimler.Length);
            isimler.Add("Oğuzhan");
            Console.WriteLine(isimler.Length);
            isimler.Add("Ahmet");
            Console.WriteLine(isimler.Length);

            foreach (string item in isimler.Items)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("Sayilar List");
            MyList<int> sayilar = new MyList<int>();
            sayilar.Add(500);
            Console.WriteLine(sayilar.Length);
            sayilar.Add(600);
            Console.WriteLine(sayilar.Length);
            sayilar.Add(700);
            Console.WriteLine(sayilar.Length);

            foreach (int item in sayilar.Items)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
