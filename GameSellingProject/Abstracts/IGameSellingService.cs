using GameSellingProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSellingProject.Abstracts
{
    internal interface IGameSellingService
    {
        void Sell(Customer customer, Game game);
    }
}
