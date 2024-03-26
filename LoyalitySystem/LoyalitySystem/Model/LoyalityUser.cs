using System.ComponentModel.DataAnnotations;

namespace LoyalitySystem.Model
{
    public class LoyalityUser
    {

        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int CompanyId { get; set; }

        [Required]
        public int Discount {  get; set; }
    }
}
