using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Id = 1;
            urun1.Adi = "Elma";
            urun1.Fiyat = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.StokAdedi = 10;

            Urun urun2 = new Urun();
            urun2.Id = 2;
            urun2.Adi = "Karpuz";
            urun2.Fiyat = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.StokAdedi = 9;

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Id + " => " + urun.Adi + " => " + urun.Fiyat + " => " + urun.Aciklama);
            }

            Console.WriteLine("--------- Metotlar --------");

            //instance -- Class örneği oluşturmak
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2(3, "Armut", "Yeşil Armut", 12, 10);
            sepetManager.Ekle2(4, "Elma", "Yeşil Elma", 12, 9);
            sepetManager.Ekle2(5, "Karpuz", "Diyerbakır Karpuz", 12, 8);

            Console.ReadLine();
        }
    }
}


// Tekrar tekrar kullanabilirliği sağlayan ortamlar
// Clean Code - Best Practice
// Do Not Repeat YOURSELF !!!