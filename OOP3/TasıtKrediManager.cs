using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class TasıtKrediManager : IKrediManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("tasıt kredisi ödemesi hesaplandı");
        }
    }
}
