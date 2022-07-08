using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Gelişitirici Yerleştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java";

            // array - dizi

            string[] kurslar = new string[] { "Yazılım Gelişitirici Yerleştirme Kampı", "Programlamaya Başlangıç İçin Temel Kurs", "Java", "Python","C++", "C","C#", "Angular" };


            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            for (int i = 1 ; i <= 10; i+=2)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
