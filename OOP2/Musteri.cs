using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class Musteri
    {
        // Matematik işlemi yapmayacağın property'e string değer verebilirsin.
        // Sayısal bir değeri tutsa bile string ver. Çünkü;
        // Matematiksel işlemlere tabi tutulmayacak.
        // Örneğin TcKimlik No, bu sadece sayısal bir veri ve
        // üzerinde hiç bir zaman matematiksel işlem yapılmayacak
        // Bu yüzden string olarak tutabiliriz.


        public int Id { get; set; }
        public string MusteriNo { get; set; }

    }
}
