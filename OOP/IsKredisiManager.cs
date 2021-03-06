using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class IsKredisiManager : IKrediManager
    {
        public void Calculate()
        {
            Console.WriteLine("İş Kredisi hesaplandı");
        }
    }
}
