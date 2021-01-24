using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "engin";
            int yas = 36;
            Kurs kurs1= new Kurs();
            kurs1.kursAdi = "C#";
            kurs1.kursunEgitmeni = "engin";
            kurs1.ızlenmeOranı = 98;

            Kurs kurs2 = new Kurs();
            kurs2.kursAdi = "java";
            kurs2.kursunEgitmeni = "kemal";
            kurs2.ızlenmeOranı = 45;

            Kurs kurs3 = new Kurs();
            kurs3.kursAdi = "C";
            kurs3.kursunEgitmeni = "emine";
            kurs3.ızlenmeOranı = 23;

            //Console.WriteLine(kurs1.kursAdi + ";" + kurs1.kursunEgitmeni);
            //Console.WriteLine("Hello World!");

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi+ ":" + kurs.kursunEgitmeni);
            }
        }       

    }

    class Kurs
    {
        public string kursAdi { get; set; }

        public string kursunEgitmeni { get; set; }

        public int ızlenmeOranı { get; set; }

    }
}
