using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager ihtiyacCreditManager = new IhtiyacCreditManager(); //ICreditManager yernine IhtiyacCreditManager da yazabiliriz bir şey değişmez

            TasitCreditManager tasitCreditManager = new TasitCreditManager();//ICredit Manager da olur

            ICreditManager konutCreditManager = new KonutCreditManager();

            ICreditManager esnafCreditManager = new EsnafCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();
            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new DatabaseLoggerService(), new FileLoggerService() };
            //Burada list halinde birden fazla log kullanıldığındaki duruma baktık
            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.Apply(esnafCreditManager, loggers); //apply'a ihitiyac kredisini gönderdik.
            
           
            List<ICreditManager> krediler = new List<ICreditManager>() {ihtiyacCreditManager, tasitCreditManager};
            
            applicationManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
