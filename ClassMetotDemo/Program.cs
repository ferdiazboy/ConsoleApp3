using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Ferdi";
            musteri1.Soyadi = "Azboy";
            musteri1.Id = 101;
            musteri1.Tckn = 00000000000;
            musteri1.Iban = "000000111111222222444444";
            musteri1.Telefonu = "05001112233";

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Mehmet";
            musteri2.Soyadi = "Bilgin";
            musteri2.Id = 102;
            musteri2.Tckn = 11111111111;
            musteri2.Iban = "111111222222444444555555";
            musteri2.Telefonu = "05002223344";

            Musteri[] musteriler = new Musteri[] {musteri1, musteri2 };

            foreach (Musteri musteri in musteriler)
            {

                Console.WriteLine(musteri.Adi+" "+musteri.Soyadi);
                
            }Console.WriteLine("-----------");

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Listele(musteri1);
            musteriManager.Sil(musteri2);
        }
    }
}
