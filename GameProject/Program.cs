using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewESatateUserValidationManager());
            gamerManager.Save(new Gamer
            {
                Id = 1,
                BirthYear = 1989,
                FirstName = "Ferdi",
                LastName = "Azboy",
                NationalityId = 111111,
                Email = "fazby@gmail.com"
            });

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Save(new Campaign
            {
                Id = 1,
                Name = "Sevgililer Günü",
                DiscountRate = 20
            });

            OrderManager orderManager = new OrderManager();
            orderManager.Save(new Order
            {
                Id = 1,
                Price = 100
            });

            Order order = new Order
            {
                Id = 1,
                Price = 100
            };

            Campaign campaign = new Campaign
            {
                Id = 1,
                Name = "Sevgililer Günü",
                DiscountRate = 20
            };
            OrderCampaignIntegrationManager orderCampaignIntegrationManager = new OrderCampaignIntegrationManager();
            
            Console.WriteLine("Order Price:", orderCampaignIntegrationManager.OrderCampaignIntegration(order, campaign));
            
        }
    }
}
