using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class MailLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Mail yollandı");
        }
    }
}
