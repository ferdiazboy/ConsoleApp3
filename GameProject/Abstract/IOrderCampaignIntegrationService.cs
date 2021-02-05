using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface IOrderCampaignIntegrationService
    {
        int OrderCampaignIntegration(Order order, Campaign campaign);
    }
}
