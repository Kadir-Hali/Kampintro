using GameIntro.Abstract;
using GameIntro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameIntro.Concrete
{
    internal class GamesManager : IGameService
    {
        public void Delete(Games games)
        {
            Console.WriteLine(games.GameName+" adlı oyun "+games.Price+ "TL güncel fiyatıyla mağazadan silindi.");
        }

        public void Save(Games games)
        {
            Console.WriteLine(games.GameName + " adlı oyun "+games.Price+"TL güncel fiyatıyla mağazaya eklendi.");
        }

        public void Update(Games games)
        {
            Console.WriteLine(games.GameName + " adlı oyunun fiyatı "+games.Price+"TL olarak güncellendi.");
        }
    }
}
