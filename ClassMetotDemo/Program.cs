// See https://aka.ms/new-console-template for more information

using ClassMetotDemo;

Musteri musteri1 = new Musteri();
{
    musteri1.Id = 1;
    musteri1.Adi = "Kadir";
    musteri1.Soyadi = "Halı";
    musteri1.Meslegi = "Yazılımcı";
    musteri1.Yasi = 22;
    
}
Musteri musteri2 = new Musteri();
{
    musteri2.Id = 2;
    musteri2.Adi = "Taha";
    musteri2.Soyadi = "Halı";
    musteri2.Meslegi = "Öğrenci";
    musteri2.Yasi = 18;
}
Musteri musteri3 = new Musteri();
{
    musteri3.Id = 3;
    musteri3.Adi = "Berat";
    musteri3.Soyadi = "Halı";
    musteri3.Meslegi = "Diş Hekimi";
    musteri3.Yasi = 28;

}
Musteri[] musteriList = new Musteri[3] { musteri1, musteri2, musteri3 };

MusteriManager musteriIslemleri = new MusteriManager();

musteriIslemleri.Listele(musteri1);
Console.WriteLine("-----------------");
musteriIslemleri.Listele(musteri2);
Console.WriteLine("-----------------");
musteriIslemleri.Listele(musteri3);
Console.WriteLine("-----------------");

musteriIslemleri.Ekle(musteri1);
Console.WriteLine("-----------------");
musteriIslemleri.Ekle(musteri2);
Console.WriteLine("-----------------");
musteriIslemleri.Ekle(musteri3);
Console.WriteLine("-----------------");

musteriIslemleri.Sil(musteri1);
Console.WriteLine("-----------------");
musteriIslemleri.Sil(musteri2);
Console.WriteLine("-----------------");
musteriIslemleri.Sil(musteri3);
Console.WriteLine("-----------------");
