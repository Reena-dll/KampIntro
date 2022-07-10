using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri gercekMusteri = new GercekMusteri();
            gercekMusteri.Id = 1;
            gercekMusteri.MusteriNo = "12345";
            gercekMusteri.Adi = "Engin";
            gercekMusteri.Soyadi = "Demiroğ";
            gercekMusteri.TcNo = "12345678910";

            //Kodlama.io

            TuzelMusteri tuzelMusteri = new TuzelMusteri();
            tuzelMusteri.Id = 2;
            tuzelMusteri.MusteriNo = "54321";
            tuzelMusteri.SirketAdi = "Kodlama.io";
            tuzelMusteri.VergiNo = "1234567890";

            // Gerçek Müşteri - Tüzel Müşteri
            // SOLID prensiplerinden L harfi
            // Soyutlama 

            Musteri musteri = new GercekMusteri();
            Musteri musteri2 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri);
        }
    }
}
