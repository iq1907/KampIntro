using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "ismail", "melis", "nazmiye" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //isimler = new string[5];
            //isimler[4] = "sevgi";
            //Console.WriteLine(isimler[4] + " " + isimler[0]);

            List<string> isimler2 = new List<string>() { "ismail", "melis", "nazmiye" };

            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            isimler2.Add("sevgi");
            Console.WriteLine(isimler2[3]);



        }
    }
}
