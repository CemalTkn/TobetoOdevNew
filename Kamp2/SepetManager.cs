using System;
using System.Collections.Generic;
using System.Text;

namespace Kamp2
{
    class SepetManager
    {
        public void Ekle(Product urun)
        {
            Console.WriteLine("Tebrikler Sepete eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunadi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler Sepete eklendi : " + urunadi);
        }
    }
}
