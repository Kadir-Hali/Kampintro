using GameIntro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameIntro.Abstract
{
    internal interface ISalesService
    {
        void Add(Sales sales,Player player,Games games);
        void AddWithCampaign(Sales sales,Player player,Games games,Campaign campaign);
        void Delete(Sales sales, Player player, Games games, Campaign campaign);
    }
}
