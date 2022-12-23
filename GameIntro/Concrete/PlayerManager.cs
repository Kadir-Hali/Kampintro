using GameIntro.Abstract;
using GameIntro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameIntro.Concrete
{
    internal class PlayerManager : BasePlayerManager
    {
        private IPlayerCheckService _playerCheckService;

        public PlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }

        public override void Save(Player player)
        {
            if (_playerCheckService.CheckIfRealPerson(player))
            {
                base.Save(player);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
             
        }
    }
}
