using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılm geliştirci";
            string kurs2 = "program başlangıç";
            string kurs3 = "java";

            string[] kurslar = new string[] {"yazılım geliştirici" ,
                "program başlangıç","java","^c#"};


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
