using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Dolar Düşmüş");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Dolar Çıkmış");
            }
            else
            {
                Console.WriteLine("Dolar değişmemiş");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Butonu");

            }
            else
            {
                Console.WriteLine("Buton Yok");
            }


            //Console.WriteLine(kategoriEtiketi);
        }
    }
}
