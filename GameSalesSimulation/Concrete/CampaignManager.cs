using GameSalesSimulation.Abstract;
using GameSalesSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesSimulation.Concrete
{
    public class CampaignManager : ICampaignService
    {
        List<Campaign> campaigns = new List<Campaign>();
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya Tanımlandı. " + campaign.Name);
            campaigns.Add(campaign);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya Listeden Kaldırıldı. " + campaign.Name);
            campaigns.Remove(campaign);
            ListCampaign();
        }

        public void ListCampaign()
        {
            Console.WriteLine("Mevcut Olan Kampanyalar.");
            foreach (Campaign campaign in campaigns)
            {
                Console.WriteLine(campaign.Name);
            }
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya Güncellendi. " + campaign.Name);
        }
    }
}
