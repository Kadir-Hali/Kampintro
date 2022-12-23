using GameIntro.Abstract;
using GameIntro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameIntro.Concrete
{
    internal class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Title+" başlıklı kampanya ile %"+campaign.CampaignRate+" indirim mağazaya eklendi");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Title + " başlıklı kampanya ile gelen %"+campaign.CampaignRate+" indirim mağazadan silindi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Title + " başlıklı kampanyanın indirim oranı %"+campaign.CampaignRate+" olarak güncellendi");
        }
    }
}
