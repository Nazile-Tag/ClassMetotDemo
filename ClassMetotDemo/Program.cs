using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 223344550;
            musteri1.Adi = "Murat";
            musteri1.Soyadi = "Tağ";
            musteri1.Sehir = "Mersin";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 112233445;
            musteri2.Adi = "Nazile";
            musteri2.Soyadi = "Tağ";
            musteri2.Sehir = "Ankara";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 112256788;
            musteri3.Adi = "Ercan";
            musteri3.Soyadi = "Uysal";
            musteri3.Sehir = "Tokat";

            Musteri musteri4 = new Musteri();
            musteri4.Id = 112256789;
            musteri4.Adi = "Feray";
            musteri4.Soyadi = "Uysal";
            musteri4.Sehir = "Bartın";

            Musteri musteri5 = new Musteri();
            musteri5.Id = 134569999;
            musteri5.Adi = "Akın Sercan";
            musteri5.Soyadi = "Budak";
            musteri5.Sehir = "Ankara";



            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4, musteri5 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Id + musteri.Adi + musteri.Soyadi + musteri.Sehir);
            }




        }
    }
}
