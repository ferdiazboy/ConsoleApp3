using System;

namespace eTicaretOdevi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ürün tipinde nesnelerimizi oluşturduk
            Urun bilgisayar = new Urun();
            Urun telefon = new Urun();
            Urun tablet = new Urun();

            //Ürün özelliklerimiz tanımladık
            bilgisayar.adi = "Asus K55VD";
            bilgisayar.markasi = "Asus";
            bilgisayar.fiyati = 7000;
            bilgisayar.satici = "Hepsiburada";
            bilgisayar.indirimOrani = 10;

            telefon.adi = "Redmi 9T";
            telefon.markasi = "Xiaomi";
            telefon.fiyati = 3500;
            telefon.satici = "Hepsiburada";
            telefon.indirimOrani = 5;

            tablet.adi = "Galaxy Tab s6 Lite";
            tablet.markasi = "Samsung";
            tablet.fiyati = 2500;
            tablet.satici = "Hepsiburada";
            tablet.indirimOrani = 15;

            //Ürünlerimizi bir dizide tutalım
            Urun[] urunler = new Urun[] {bilgisayar, telefon, tablet };

            //foreach ile ürün listeleme
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.adi);
                Console.WriteLine(urun.markasi);
                Console.WriteLine(urun.fiyati);
                Console.WriteLine(urun.satici);
                Console.WriteLine(urun.indirimOrani);
                Console.WriteLine();
            }

            //for dögüsü ile ürün listeleme
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].adi);
                Console.WriteLine(urunler[i].markasi);
                Console.WriteLine(urunler[i].fiyati);
                Console.WriteLine(urunler[i].satici);
                Console.WriteLine(urunler[i].indirimOrani);
                Console.WriteLine();
            }

            //while ile ürün listeleme
            int j = 0;
            while (j<urunler.Length)
            {
                Console.WriteLine(urunler[j].adi);
                Console.WriteLine(urunler[j].markasi);
                Console.WriteLine(urunler[j].fiyati);
                Console.WriteLine(urunler[j].satici);
                Console.WriteLine(urunler[j].indirimOrani);
                Console.WriteLine();
                j++;
            }
        }
        class Urun //Ürün sınfını oluşturduk
        {
            public string adi { get; set; }
            public string markasi { get; set; }
            public int fiyati { get; set; }
            public string satici { get; set; }
            public int indirimOrani { get; set; }
        }
    }
}
