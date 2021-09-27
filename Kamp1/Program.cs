using System;

namespace Kamp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirme KAmpı";
            string kurs2 = "Programlamaya başlangıç";
            string kurs3 = "Java";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);

            Console.WriteLine("------");
            //array - dizi

            string[] kurslar = new string[] { "Yazılım Geliştirme KAmpı",
                "Programlamaya başlangıç",
                "Java","Python" };

            for (int i = 0; i < kurslar.Length; i++) //Length (eleman sayısı demektir)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");
            Console.WriteLine("------");

            foreach (string kurs in kurslar) //kurs = alias atamak
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonnu - footer");
        }
    }
}
