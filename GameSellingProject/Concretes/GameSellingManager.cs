using GameSellingProject.Abstracts;
using GameSellingProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSellingProject.Concretes
{
    public class GameSellingManager : IGameSellingService
    {
        
        ICampaignService _campaignService;
        

        public GameSellingManager(ICampaignService campaignService)
        {
            _campaignService = campaignService;
            
        }

        public void Sell(Customer customer, Game game)
        {
            Console.WriteLine(game.GameName + "has sold to this person :" + customer.PersonName);

            if (customer.PersonAge >= 18)
            {
                Campaign campaign = new Campaign();
                _campaignService.Add(campaign);
            }




        }
    }
}
