using System;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace LoyalitySystem.Model
{
    public class Campaign
    {
        public int Id { get; set; }

        [Required]
        public string CompanyName { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public int Duration { get; set; }
    }
}
