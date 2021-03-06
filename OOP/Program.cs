using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKredisiManager();
            IKrediManager arabaKrediManager = new ArabaKredisiManager();
            IKrediManager isKrediManager = new IsKredisiManager();
            IKrediManager evKredisiManager = new EvKredisiManager();

            ILoggerService smsLoggerService = new SmsLogger();
            ILoggerService mailLoggerService = new MailLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(evKredisiManager, mailLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, arabaKrediManager };

        }
    }
}
