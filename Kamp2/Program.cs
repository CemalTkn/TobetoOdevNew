using System;

namespace Kamp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string arunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] { };

            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyatı = 15;
            product1.Aciklama = "Amasya elması";

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyatı = 80;
            product2.Aciklama = "Diyarbakır karpuzu";

            Product[] urunler = new Product[] { product1, product2 };

            foreach (var product in urunler)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyatı);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("------------------");
            }

            Console.WriteLine("----------Metotlar---------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 8);
        }
    }
}
