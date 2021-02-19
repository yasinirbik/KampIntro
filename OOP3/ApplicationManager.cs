using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        public void Apply(ICreditManager creditManager, List<ILoggerService> loggerServices)
        {
            //Başvuran bilgilerini değerlendirme
            //
            creditManager.Calculate();
            //loggerService.Log();  //Bir tek lgger kullanacaksak bu yapı yeterli//
            foreach (var loggerService in loggerServices)//birden fazla logger kullanacaksak bu yapıyla kullanırız
            {
                loggerService.Log();
            }
        }
        public void KrediOnBilgilendirmesiYap(List<ICreditManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Calculate();
            }

        }
    }
}
