using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "kategori";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmısMı = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("azalış butonu");
            }
            else if(dolarDun<dolarBugun)
            {
                Console.WriteLine("artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi");  
            }

            if (sistemeGirisYapmısMı==true)
            {
                Console.WriteLine("ayarlar butonu");
            }

            else
            {
                Console.WriteLine("GİRİŞ YAPIN");
            }

            Console.WriteLine(kategoriEtiketi);
            Console.ReadLine();
        }
    }
    
}
