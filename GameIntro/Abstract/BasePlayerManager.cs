using GameIntro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameIntro.Abstract
{
    internal abstract class BasePlayerManager : IPlayerService
    {
        public void Delete(Player player)
        {
            Console.WriteLine(player.FirstName + " adlı oyuncu silindi.");
        }

        public virtual void Save(Player player)
        {
            Console.WriteLine(player.FirstName + " adlı oyuncu eklendi.");
        }

        public void Update(Player player)
        {
            Console.WriteLine(player.FirstName + " adlı oyuncunun bilgileri güncellendi.");
        }
    }
}
