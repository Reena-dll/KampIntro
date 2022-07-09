using System;
using System.Collections.Generic;

namespace Koleksiyonlar2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            MyList<string> sehirler2 = new MyList<string>();

            sehirler2.Add("İstanbul");
            sehirler2.Add("Ankara");
            sehirler2.Add("Antalya");
            sehirler2.Add("Adana");
            sehirler2.Add("İzmir");
            Console.WriteLine(sehirler2.Length);

            foreach (string item in sehirler2.Item)
            {
                Console.WriteLine(item);
            }
        }

    }

    class MyList<T>
    {
        T[] items;
        public MyList()
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
        }

        public int Length
        {
            get { return items.Length; }
        }

        public T[] Item
        {
            get { return items; }
        }
    }
}
