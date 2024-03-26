using LoyalitySystem.Model;

namespace LoyalitySystem.Repository.IRepository
{
    public interface ICampaignRepository
    {
        List<Campaign> GetCampaigns();

        Campaign GetCampaignById(int campaignId);

        Campaign AddCampaign(Campaign campaignId);

        void UpdateCampaign(Campaign campaignId);

        void DeleteCampaign(int campaignId);

        bool SaveChanges();
    }
}
