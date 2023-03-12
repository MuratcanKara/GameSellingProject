using GameSellingProject.Abstracts;
using GameSellingProject.Concretes;
using GameSellingProject.Entities;

namespace GameSellingProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            Game game1 = new Game();
            Campaign campaign1= new Campaign();

            customer1.PersonId= 1;
            customer1.PersonName = "Muratcan";
            customer1.PersonLastName = "Kara";
            customer1.DateOfBirth = new DateTime(2004, 4, 2);
            customer1.PersonAge= 0;
            customer1.TcNo = "52282131712";

            game1.GameId = 1;
            game1.CategoryId = 2;
            game1.GameName = "GTA";
            game1.GameDescription = "u can jerk off if u want";

            campaign1.CampaignId = 3;
            campaign1.CampaignName = "GYY";
            campaign1.CampaignDescription = "Götten Yiyenler Yaşadı";


            

            ICustomerService customerService = new BaseCustomerManager();
            ICampaignService campaignService = new CampaignManager();
            IGameSellingService gameSellingManager = new GameSellingManager(campaignService);
            BlizzardCustomerManager baseCustomerManager = new BlizzardCustomerManager(new CustomerCheckManager());
            

            baseCustomerManager.customerCheckService1.CheckIfRealPerson(customer1);
            baseCustomerManager.customerCheckService1.IfCustomerRealPerson("52282131712", "Muratcan", "Kara", new DateTime(2004, 2, 4));
            baseCustomerManager.CreateAcc(customer1);
        }
    }
}