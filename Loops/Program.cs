using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //array-dizi
            string[] kurslar = new string[] { "Yazilim Gelistirici Yetistirme Kursu", "Programlamaya Baslangic Kursu", "Java", "Python" };
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)//kursları dolaş
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Sayfo sonu-footer");

            for (int i = 1; i <= 10; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
