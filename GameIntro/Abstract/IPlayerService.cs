using GameIntro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameIntro.Abstract
{
    internal interface IPlayerService
    {
        void Save(Player player);
        void Update(Player player); 
        void Delete(Player player); 
    }
}
