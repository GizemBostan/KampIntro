using System;

namespace ClassDemoMetot
{
    class Program
    {
        static void Main(string[] args)
        {

           
            Musteri musteri1 = new Musteri();
            Musteri musteri2 = new Musteri();
            Musteri musteri3 = new Musteri();

            Musteri[] musteriler = new Musteri[] { musteri1,musteri2,musteri3 };

            musteri1.Id = 1;
            musteri1.MusteriAdi="abcd";
            musteri1.MusteriYasi = 34;
            musteri1.MusteriOzellik = "orta yaş";

            musteri2.Id = 2;
            musteri2.MusteriAdi = "erty";
            musteri2.MusteriYasi = 14;
            musteri2.MusteriOzellik = "genç";

            musteri3.Id = 3;
            musteri3.MusteriAdi = "uıop";
            musteri3.MusteriYasi = 67;
            musteri3.MusteriOzellik = "yaşlı";

            MusteriManager musteriCagrı = new MusteriManager();
            musteriCagrı.Add(musteri1);
            musteriCagrı.Add(musteri2);

            Console.WriteLine("--------------------");
            musteriCagrı.Delete(musteri2);
            Console.WriteLine("--------------------");

           musteriCagrı.List(musteriler);


        }
    }
}
