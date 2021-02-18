using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //Encapsulation
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " guncellendi.");
        }







        //int ve void
      //  public int Topla1(int sayi1, int sayi2) /**/int de döndürdügümüz sayi üüzerinde yeniden işlemler yapabiliriz
        //{
         //   return sayi1 + sayi2;
       // }
        //public void Topla2(int sayi1, int sayi2) //Burada işi yaparız tekrar üzerinde işlkem yapamayız
        //{
         //   Console.WriteLine(sayi1+sayi2);
        //}

    }
}
