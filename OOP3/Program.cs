
using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasıtKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();


            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKrediManager(),new List<ILoggerService> { new DatabaseLoggerService(), new SmsManager()});

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
           

        }
    }
}
