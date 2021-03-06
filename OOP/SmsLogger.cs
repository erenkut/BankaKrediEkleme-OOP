using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class SmsLogger : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Sms Gönderildi");
        }
    }
}
