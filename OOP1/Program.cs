using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Böyle de 
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;
            //Böyle de tanımlayabiliriz.
            Product product2 = new Product { Id = 2, CategoryId = 5, UnitInStock = 5,
                ProductName = "Kalem", UnitPrice = 35};
            //PascalCase    //camelCase  //Case sensitive
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);




          //  productManager.Topla2(3, 6);
          //  int sonuc = productManager.Topla1(3, 6);
          //  Console.WriteLine(sonuc*2);
        }
    }
}
