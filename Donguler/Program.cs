using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] kurslar = new string[] { "c#", "java", "pyton","java script","C++" };

            int[] sayilar = new int[] {1,5,6,7};

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }

            
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(i + " " + kurslar[i]);
            }

            Console.WriteLine("Ara");

            int j = 0;
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(j + " " + kurs);
                j++;
            }

            //Console.WriteLine("Hello World!");
        }
    }
}
