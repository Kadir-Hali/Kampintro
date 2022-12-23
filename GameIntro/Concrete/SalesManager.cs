using GameIntro.Abstract;
using GameIntro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameIntro.Concrete
{
    internal class SalesManager : ISalesService
    {
        public void Add(Sales sales, Player player, Games games)
        {
            Console.WriteLine(player.FirstName+" adlı müşteri "+games.GameName+" adlı oyunu "+sales.Id+" satış numarasıyla almıştır.");
        }

        public void AddWithCampaign(Sales sales, Player player, Games games, Campaign campaign)
        {
            Console.WriteLine(player.FirstName + " adlı müşteri " + games.GameName + " adlı oyunu "+campaign.Title+" başlıklı kampanya ile "+sales.GamePrice+"TL ödeyerek " + sales.Id + " satış numarasıyla almıştır.");
        }

        public void Delete(Sales sales, Player player, Games games, Campaign campaign)
        {
           Console.WriteLine(player.FirstName + " adlı müşteri " + games.GameName + " adlı oyunu " + campaign.Title + " başlıklı kampanya ile "+sales.GamePrice+"TL ödeyerek " + sales.Id + " satış numarasıyla almış ve sonrasında iptal etmiştir.");
        }
    }
}
