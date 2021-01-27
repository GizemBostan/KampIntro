using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class SmsManager : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("sms yollandı");
        }
    }
}
