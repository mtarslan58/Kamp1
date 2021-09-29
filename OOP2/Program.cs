using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Muhammed Talha Arslan
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Id = 3;
            musteri1.Adi = "Muhammed Talha";
            musteri1.SoyAdi = "Arslan";
            musteri1.TcNo = "12345678910";

            //Feyza Arslan

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.MusteriNo = "54321";
            musteri2.Id = 2;
            musteri2.SirketAdi = "Arslan";
            musteri2.VergiNo = "1234567890";




            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();


            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);
        }
    }
}
