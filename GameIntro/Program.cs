// See https://aka.ms/new-console-template for more information
using GameIntro.Abstract;
using GameIntro.Concrete;
using GameIntro.Entities;
using GameIntro.Adapters;

Console.WriteLine("----------Oyuncu İşlemleri----------");
BasePlayerManager playerManager = new PlayerManager(new MernisServiceAdapter());
Player player1=(new Player { DateOfBirth= new DateTime(2000,2,10),FirstName="Abdulkadir",LastName="Halı",NationalityId="18869820608",Id=1});
Player player2 = (new Player { DateOfBirth = new DateTime(2000, 5, 19), FirstName = "Doğa", LastName = "Erol", NationalityId = "12345678910", Id = 2 });
Player player3 = (new Player { DateOfBirth = new DateTime(2003, 8, 8), FirstName = "Beraat", LastName = "Halı", NationalityId = "12345678911", Id = 3 });
playerManager.Save(player1);
playerManager.Delete(player2);
playerManager.Update(player3);


Console.WriteLine("----------Oyun İşlemleri----------");
GamesManager gamesManager = new GamesManager();
Games games1=(new Games { Id= 1,GameName="Fifa 2023",Price=250});
Games games2 = (new Games { Id = 2, GameName = "Valorant", Price = 200 });
Games games3 = (new Games { Id = 3, GameName = "Call of Duty: Warzone", Price = 300 });
gamesManager.Save(games1);
gamesManager.Update(games2);
gamesManager.Delete(games3);

Console.WriteLine("----------Kampanya İşlemleri----------");
CampaignManager campaignManager= new CampaignManager();
Campaign campaign1=(new Campaign { Id=1,Title="Hoşgeldin Kampanyası",CampaignRate=10});
Campaign campaign2 = (new Campaign { Id = 2, Title = "Yeni Yıl Kampanyası", CampaignRate = 20 });
Campaign campaign3 = (new Campaign { Id = 3, Title = "Öğrenci Kampanyası", CampaignRate = 50 });
campaignManager.Add(campaign1);
campaignManager.Update(campaign2);
campaignManager.Delete(campaign3);


Console.WriteLine("----------Satış İşlemleri----------");
SalesManager salesManager= new SalesManager();
Sales sales1=(new Sales {Id=1,PlayerName="Abdulkadir",GameName= "Fifa 2023",CampaignName= "Hoşgeldin Kampanyası",DiscountRate=10,GamePrice=225 });
Sales sales2 = (new Sales { Id = 2, PlayerName = "Doğa", GameName = "Valorant", CampaignName = "Yeni Yıl Kampanyası", DiscountRate = 20, GamePrice = 160 });
Sales sales3 = (new Sales { Id = 3, PlayerName = "Beraat", GameName = "Call of Duty: Warzone", CampaignName = "Öğrenci Kampanyası", DiscountRate = 50, GamePrice = 150 });
salesManager.Add(sales1,player1,games1);
salesManager.AddWithCampaign(sales2,player2,games2,campaign2);
salesManager.Delete(sales3,player3,games3,campaign3);

Console.ReadLine(); 
