using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + "  Müşteri eklendi");
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşteri Adı : " + musteri.Adi);
            Console.WriteLine("Müşteri Soyadı : " + musteri.Soyadi);
            Console.WriteLine("Müşteri Mesleği : " + musteri.Meslegi);
            Console.WriteLine("Müşteri Yaşı : " + musteri.Yasi);


        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " Müşteri Silindi");
        }
    }
}
