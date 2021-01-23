using System;
using System.Collections.Generic;

namespace Gun4Odev3Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            Console.WriteLine(sehirler.Count);

           // sehirler.Add("Diyarbakır");

            MyList<string> sehirler2 = new MyList<string>();
            Console.WriteLine(sehirler2.Count);
            //sehirler2.Add("Diyarbakır");
        }
    }
    class MyList<T> //Generic class
    {
        T[] _array;
        public void Add(T item)
        {
            _array = new T[0];
        }

        public int Count
        {
            get { return _array.Length; }
        }

    }
}
