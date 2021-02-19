using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class IndividualCustomer:Customer//Gerçek Müşteri inheritance
    {
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
