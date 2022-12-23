using GameIntro.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameIntro.Entities
{
    internal class Sales:IEntity
    {
        public int Id { get; set; }
        public string PlayerName { get; set; }
        public string GameName { get; set; }
        public string CampaignName { get; set; }
        public int DiscountRate { get; set; }
        public int GamePrice { get; set; }
    }
}
