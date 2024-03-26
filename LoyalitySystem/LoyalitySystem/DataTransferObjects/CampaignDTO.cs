using System.ComponentModel.DataAnnotations;

namespace LoyalitySystem.DataTransferObjects
{
    public class CampaignDTO
    {
        public int Id { get; set; }

        public string CompanyName { get; set; }

        public DateTime StartDate { get; set; }

        public int Duration { get; set; }
    }
}
