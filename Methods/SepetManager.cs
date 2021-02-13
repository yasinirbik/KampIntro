using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        public void Ekle(Product urun)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi: " + urun.Adi);
            //
            //
        }
        public void Ekle2(string urunAdi, string Aciklama, double Fiyat, int StokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi: " + urunAdi);
        }
    }
}
