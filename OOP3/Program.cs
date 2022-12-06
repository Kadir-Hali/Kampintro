// See https://aka.ms/new-console-template for more information

using OOP3;

IKrediManager ihtiyacKrediManager=new IhtiyacKrediManager();
ihtiyacKrediManager.Hesapla();

IKrediManager konutKrediManager = new KonutKrediManager();
konutKrediManager.Hesapla();

IKrediManager tasitKrediManager = new TasitKrediManager();
tasitKrediManager.Hesapla();