using System;
using System.Collections.Generic;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursunEgitmeni = "Engin";
            kurs1.KursIzlenmeOran = 50;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.KursunEgitmeni = "İsmail";
            kurs2.KursIzlenmeOran = 40;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Pyton";
            kurs3.KursunEgitmeni = "Melis";
            kurs3.KursIzlenmeOran = 70;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "c++";
            kurs4.KursunEgitmeni = "Can";
            kurs4.KursIzlenmeOran = 100;

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4 };

            List<Kurs> kursList = new List<Kurs> {kurs1,kurs2,kurs3,kurs4 };

            foreach (var kurs in kursList)
            {
                Console.WriteLine(kurs.KursAdi + " -list" );
            }

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " " + kurs.KursunEgitmeni);
            }

            Insan[] humans = new Insan[2];

            Insan myHuman1 = new Insan();
            myHuman1.isim = "ismail";
            myHuman1.yas = 41;
            myHuman1.dogumYeri = "Karabuk";

            Insan myHuman2 = new Insan();
            myHuman2.isim = "melis";
            myHuman2.yas = 15;
            myHuman2.dogumYeri = "Karabuk";

            humans[0] = myHuman1;
            humans[1] = myHuman2;

            foreach (var human in humans)
            {
                Console.WriteLine(human.isim + " " + human.yas);
            }

            //Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursunEgitmeni { get; set; }
        public int KursIzlenmeOran { get; set; }
    }

    class Insan
    {
        public string isim { get; set; }
        public int yas { get; set; }
        public string dogumYeri { get; set; }
    }
}
