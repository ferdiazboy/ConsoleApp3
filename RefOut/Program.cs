using System;

namespace RefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int kenar1 = 5;
            int kenar2 = 4;

            
            Console.WriteLine(DiktortgenAlaniHesapla(kenar1,kenar2));// alan 8 olarak hesaplandı. 

            //Console.WriteLine(DiktortgenAlaniHesapla(ref veya outkenar1, kenar2)); 
            //Eğer kenar1 ref veya out olarak tanımlansaydı Kenar1 2 olarak hesaplanırdı

            Console.WriteLine(kenar1); //kenar1 5
        }

        //static int DiktortgenAlaniHesapla(ref veya out int kenar1, int kenar2)
        static int DiktortgenAlaniHesapla(int kenar1, int kenar2) 
        {
            kenar1 = 2;
            return kenar1 * kenar2;
        }
    }
}
