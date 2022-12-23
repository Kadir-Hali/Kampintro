using GameIntro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameIntro.Abstract
{
    internal interface IGameService
    {
        void Save(Games games);
        void Update(Games games);
        void Delete(Games games);
    }
}
