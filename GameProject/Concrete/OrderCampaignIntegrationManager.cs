using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class OrderCampaignIntegrationManager : IOrderCampaignIntegrationService
    {
        public int OrderCampaignIntegration(Order order, Campaign campaign)
        {
            return order.Price - (order.Price * (campaign.DiscountRate / 100));
        }
    }
}
