using System;
using System.Collections.Generic;

namespace Gun4Odev4Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> AdYas = new Dictionary<string, int>();

            AdYas.Add("Ferdi", 30);
            AdYas.Add("Serhat", 17);

            foreach (var item in AdYas)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(AdYas.Count);
            Console.WriteLine();

            MyDictionary<string, int> AdYas2 = new MyDictionary<string, int>();

            AdYas2.Add("Ferdi", 30);
            AdYas2.Add("Serhat", 17);
            AdYas2.Add("Furkan", 23);

            Console.WriteLine(AdYas2.Count);
            //for (int i = 0; i < AdYas2.Count; i++)
            //{
            //    Console.WriteLine(AdYas2);
            //}

            //foreach (var item in AdYas2)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
