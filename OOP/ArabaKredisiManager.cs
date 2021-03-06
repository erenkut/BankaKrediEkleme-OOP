using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class ArabaKredisiManager : IKrediManager
    {
        public void Calculate()
        {
            Console.WriteLine("Araba kredisi Ödeme planı hesaplandı");
        }
    }
}
