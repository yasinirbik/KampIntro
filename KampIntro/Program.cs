using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety-tip güvenliği
            // Do not Repeat Yourself
            string kategoriEtiketi = "kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu.");
            }
            else
            {
                Console.WriteLine("Giris yap butonu.");

            }
            Console.WriteLine(kategoriEtiketi);
            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalis Oku");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artis Oku");
            }
            else
            {
                Console.WriteLine("Esittir Oku");
            }

        }
    }
}
