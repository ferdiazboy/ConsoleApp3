using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler1 = new List<string>();
            isimler1.Add("Mercan");
        

            MyList<string> isimler2 = new MyList<string>();
            isimler2.Add("Ferdi");
          
            
        }
    }
}
