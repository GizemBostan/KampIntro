using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManeger
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("sepete eklendi: " + urun.Adi);
        }

        public void Ekle2(string urunadi, string aciklama, double fiyat,int stokAdeti)
        {
            Console.WriteLine("sepete eklendi");
        }

    }
}
