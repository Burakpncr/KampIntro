using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "Yazılım Geliştime Kampı", "Programlamaya Giriş için Temel Kurs","Java","python","C#" };
           
            Console.WriteLine("sayfa başı - header");
            
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            
            Console.WriteLine("For bitti");
            
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
