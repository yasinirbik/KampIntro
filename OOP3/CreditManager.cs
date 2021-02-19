using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface ICreditManager //class'ı interface yaparız
    {
        void Calculate();
        void DoSomething();
    }
}
//interface'i  birbirinin alterantifi olan ama kod içerikleri farklı olan durumlar için kulanırız