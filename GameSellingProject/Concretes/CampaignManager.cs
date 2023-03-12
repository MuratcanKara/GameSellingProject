using GameSellingProject.Abstracts;
using GameSellingProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSellingProject.Concretes
{
    internal class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "has added to the system!");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "has deleted from the system!");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "has updated!");
        }
    }
}
