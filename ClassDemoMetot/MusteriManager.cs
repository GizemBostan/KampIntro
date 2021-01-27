using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoMetot
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + "  " + musteri.MusteriAdi + "  " + musteri.MusteriYasi + "  " + musteri.MusteriOzellik);
            Console.WriteLine("müşteriler eklenmiştir");
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + "  " + musteri.MusteriAdi + "  " + musteri.MusteriYasi + "  " + musteri.MusteriOzellik );
            Console.WriteLine("müşteriler silinmiştir");
        }


       
        public void List(Musteri[] musteri)
        {
            for (int i = 0; i < musteri.Length; i++)
            {
                Console.WriteLine(musteri[i].Id + " "+ musteri[i].MusteriAdi +" " + musteri[i].MusteriYasi + " " + musteri[i].MusteriOzellik);
   
            }
            Console.WriteLine("müşteriler listelendi");

            
        }
    }
}
