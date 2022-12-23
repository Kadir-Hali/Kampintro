using GameIntro.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameIntro.Entities
{
    internal class Campaign:IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int CampaignRate { get; set; }
    }
}
