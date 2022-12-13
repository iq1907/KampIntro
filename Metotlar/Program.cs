using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Kapruz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2};

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi + "-" + urun.Aciklama);
                Console.WriteLine("-------------------------");
            }

            Console.WriteLine("--------Methodlar----------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle2("armut", "yeşil", 12, 4);
            sepetManager.Ekle2("elma", "kırmızı", 10, 5);
            sepetManager.Ekle2("karpuz", "yepyeşil", 20, 0);


        }
    }
}
