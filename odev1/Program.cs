using System;

namespace odev1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[] { 5, 7, 9, 11, 12, 15, 18, 22,24,100};

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }

            Console.ReadLine();
        }
    }
}
