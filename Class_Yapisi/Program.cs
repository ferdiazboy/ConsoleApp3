using System;

namespace Class_Yapisi
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            Kurs kurs2 = new Kurs();
            Kurs kurs3 = new Kurs();

            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.izlenmeOrani = 68;

            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem";
            kurs2.izlenmeOrani = 64;

            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay";
            kurs3.izlenmeOrani = 80;

            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);
            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3, };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " " + kurs.Egitmen);
            }
        }
        class Kurs
        {
            public string KursAdi { get; set; }
            public string Egitmen { get; set; }
            public int izlenmeOrani { get; set; }
        }

        
    }
}
