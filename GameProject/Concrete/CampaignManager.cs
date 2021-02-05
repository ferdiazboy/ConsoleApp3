using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign deleted" + " " + campaign.Name);
        }

        public void Save(Campaign campaign)
        {
            Console.WriteLine("Campaign saved"+ " " + campaign.Name);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign updated" + " " + campaign.Name);
        }
    }
}
