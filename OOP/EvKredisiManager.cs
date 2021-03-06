using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class EvKredisiManager : IKrediManager
    {
        public void Calculate()
        {
            Console.WriteLine("Ev kredisi hesaplandı");
        }
    }
}
