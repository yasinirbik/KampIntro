using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }//Refereans anahtarıdır kodun okunurluğu için buraya yazdık. Yoksa başka yere yazsakta program çalışacakıtr.
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitInStock { get; set; }

    }
}
