using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            // sayi1 ?? 30


            int[] sayilar1 = new int[] { };
            int[] sayilar2 = new int[] { };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar[0] ?? 999
        }
    }
}
