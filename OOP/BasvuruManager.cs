using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            krediManager.Calculate();
            loggerService.Log();
        }

        public void KrediBilgilendirmesi(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Calculate();                
            }
        }
    }
}
