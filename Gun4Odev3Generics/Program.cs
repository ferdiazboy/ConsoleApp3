using System;
using System.Collections.Generic;

namespace Gun4Odev3Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Diyarbakır");
            sehirler.Add("Diyarbakır");
            sehirler.Add("Diyarbakır");
            sehirler.Add("Diyarbakır");
            Console.WriteLine(sehirler.Count);

           

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Diyarbakır");
            sehirler2.Add("Diyarbakır");
            sehirler2.Add("Diyarbakır");
            sehirler2.Add("Diyarbakır");
            sehirler2.Add("Diyarbakır");
            Console.WriteLine(sehirler2.Count);
            
        }
    }
    class MyList<T> //Generic class
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
        }
        public int Count
        {
            get { return _array.Length; }
        }
    }
}
