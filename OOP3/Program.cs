// See https://aka.ms/new-console-template for more information

using OOP3;

IKrediManager ihtiyacKrediManager=new IhtiyacKrediManager();
IKrediManager konutKrediManager = new KonutKrediManager();
IKrediManager tasitKrediManager = new TasitKrediManager();

ILoggerService databaseLoggerService = new DatabaseLoggerService();
ILoggerService fileLoggerService= new FileLoggerService();

BasvuruManager basvuruManager=new BasvuruManager();
basvuruManager.Basvuruyap(tasitKrediManager,fileLoggerService);

List<IKrediManager> krediler=new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager };
//basvuruManager.KrediOnBilgilendirmesiYap(krediler);
