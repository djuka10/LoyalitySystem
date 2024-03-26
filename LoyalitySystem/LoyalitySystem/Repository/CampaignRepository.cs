using LoyalitySystem.Data;
using LoyalitySystem.Model;
using LoyalitySystem.Repository.IRepository;

namespace LoyalitySystem.Repository
{
    public class CampaignRepository : ICampaignRepository
    {
        private readonly ApplicationDbContext context;

        public CampaignRepository(ApplicationDbContext context) { this.context = context; }

        public Campaign AddCampaign(Campaign campaignId)
        {
            var createdEntity = context.Add(campaignId);
            return createdEntity.Entity;
        }

        public void DeleteCampaign(int campaignId)
        {
            var campaign = GetCampaignById(campaignId);
            context.Remove(campaign);
        }

        public List<Campaign> GetCampaigns()
        {
            return context.Campaigns.ToList();
        }

        public Campaign GetCampaignById(int campaignId)
        {
            return context.Campaigns.FirstOrDefault(u => u.Id == campaignId);
        }

        public bool SaveChanges()
        {
            return context.SaveChanges() > 0;
        }

        public void UpdateCampaign(Campaign campaignId)
        {
            throw new NotImplementedException();
        }
    }
}
