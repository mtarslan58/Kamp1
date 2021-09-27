using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {            

            int sayı1 = 10;
            int sayı2 = 30;
            sayı1 = sayı2;
            sayı2 = 65;
            Console.WriteLine(sayı1);
            //sayı1 kaçtır ?

            Console.WriteLine("-----------------");

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]);
            //sayiler1[0] kaçtır?

            Console.WriteLine("--------------");


        }
    }
}
