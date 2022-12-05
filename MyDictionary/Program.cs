// See https://aka.ms/new-console-template for more information
using MyDictionary;

myDictionary<int, string> ogrenci = new myDictionary<int, string>();
ogrenci.Add(1, "Kadir");
ogrenci.Add(2, "Berat");
ogrenci.Add(3, "Doğa");
ogrenci.Add(4, "Taha");

Console.WriteLine(ogrenci.Length);
