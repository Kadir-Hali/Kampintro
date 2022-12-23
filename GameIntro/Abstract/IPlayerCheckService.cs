using GameIntro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameIntro.Abstract
{
    internal interface IPlayerCheckService
    {
        bool CheckIfRealPerson(Player player);
   
    }
}
