using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            

            ILoggerService dbLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            List<ILoggerService> loggerServices = new List<ILoggerService>();
            loggerServices.Add(smsLoggerService);
            loggerServices.Add(dbLoggerService);

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKrediManager(), loggerServices) ;

            List<IKrediManager> krediler = new List<IKrediManager>() { tasitKrediManager, konutKrediManager };

            //basvuruManager.KrediOnBilgilendirmeYap(krediler);
            
            //Console.WriteLine("Hello World!");
        }
    }
}
