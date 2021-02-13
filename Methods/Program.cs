using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // string urunAdi = "Elma";
            // double fiyat = 4;
            // string aciklama = "Amasya Elmasi";

            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyat = 15;
            urun1.Aciklama = "Amasya Elmasi";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyat = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Product urun3 = new Product();
            urun3.Adi = "Seftali";
            urun3.Fiyat = 11;
            urun3.Aciklama = "Bursa Seftalisi";

            Product[] urunler = new Product[] { urun1, urun2, urun3 };
            foreach (var urun in urunler)
            {
                Console.WriteLine("Urunun adi: " + urun.Adi);
                Console.WriteLine("Urunun fiyatı: " + urun.Fiyat);
                Console.WriteLine("Urunun aciklamasi: " + urun.Aciklama);
                Console.WriteLine("----------------------");
            }

            Console.WriteLine("----------Metotlar--------------");
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun3);
            sepetManager.Ekle2("Armut", "Yesil Armut", 12, 851);
            sepetManager.Ekle2("Elma", "Yesil Elma", 2, 310);
            sepetManager.Ekle2("Karpuz", "Kabak ", 62, 69);
        }
    }
}

//Don't repeat yourself - DRY - Clean Code - Best Practice