using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "1234";
            musteri1.Adi = "İsmail";
            musteri1.Soyadi = "Kaplan";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 1;
            musteri2.MusteriNo = "1234";
            musteri2.SirketAdi = "joker";
            musteri2.VergiNo = "123455";

            Musteri musteri4 = new GercekMusteri();
            Musteri musteri3 = new TuzelMusteri();
            
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);

            //musteriManager.EkleG(musteri1);



            Console.WriteLine("Hello World!");
        }
    }
}
