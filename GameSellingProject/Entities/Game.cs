using GameSellingProject.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSellingProject.Entities
{
    public class Game : IEntity
    {
        public int GameId { get; set; }
        public int CategoryId { get; set; }
        public string GameName { get; set; }
        public string GameDescription { get; set; }
        

    }
}
