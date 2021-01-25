﻿using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID 

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "12345678900";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "98765";
            musteri2.SireketAdi = "Kodlama.io";
            musteri2.VergiNo = "98765432155";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);


        }
    }
}
