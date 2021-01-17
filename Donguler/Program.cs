using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //array - dizi

            //string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            //string kurs2 = "Progamlamaya Başlangıç İçin Temel Kurs";
            //string kurs3 = "Java";

            //Console.WriteLine(kurs1);
            //Console.WriteLine(kurs2);
            //Console.WriteLine(kurs3);

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Progamlamaya Başlangıç İçin Temel Kurs", "Java" };

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("Sayfa sonu - footor");

            //foreach diziler için kullanılır
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
