using AutoMapper;
using LoyalitySystem.DataTransferObjects;
using LoyalitySystem.Model;

namespace LoyalitySystem.Profiles
{
    public class CampaignProfile : Profile
    {
        public CampaignProfile() 
        {
            CreateMap<Campaign, CampaignDTO>();

        }
    }
}
