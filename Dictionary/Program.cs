using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> lessons = new MyDictionary<string>();
            lessons.Add("matematik");
            lessons.Add("temel fizik");
            lessons.Add("edebiyat");
            lessons.Add("fen bilimleri");

        }
    }
}
