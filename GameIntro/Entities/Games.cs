using GameIntro.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameIntro.Entities
{
    internal class Games : IEntity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public double Price { get; set; }
    }
}
