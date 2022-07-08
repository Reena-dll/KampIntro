using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    public class SepetManager
    {
        // naming convetion - İsimlendirme Kuralı
        // syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrfikler. Sepete Eklendi: "+ urun.Adi);
        }

        public void Ekle2(int id, string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi: " + urunAdi);

        }
    }
}
