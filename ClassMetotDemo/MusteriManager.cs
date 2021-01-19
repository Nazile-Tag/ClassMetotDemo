using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager

    {
        public void Ekle(Musteri musteri) 
        {
            Console.WriteLine("Müşteri Eklendi" + musteri.Id + musteri.Adi + musteri.Soyadi + musteri.Sehir);
        
        }

        public void Sil(Musteri musteri) 
        {
            Console.WriteLine("Müşteri Silindi" );
        }
    }
    
}   

