using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engin Demiroğ
            IndividualCustomer  customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.MusteriNo = "12345";
            customer1.Adi = "Engin";
            customer1.Soyadi = "Demirog";
            customer1.TcNo = "111111111111";

            //Kodlama.IO
            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.MusteriNo = "245130";
            customer2.SirketAdi = "Kodlama.IO";
            customer2.VergiNo = "1234567890";
            //2 farklı müsşteri tipi Gerçek Müşteri ve tüzel Müşteri
            //SOLID

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);
        }
    }
}
