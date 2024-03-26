using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace LoyalitySystem.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class User
    {
        public int Id { get; set; }  // Primary key for the User entity

        [Required]
        public string Name { get; set; }

        [Required]
        [RegularExpression(@"^\d{3}-\d{2}-\d{4}$", ErrorMessage = "Invalid SSN format")]
        public string SSN { get; set; }

        [Required]
        public DateTime DOB { get; set; }

        public string? HomeStreet { get; set; }

        public string? HomeCity { get; set; }

        [StringLength(2)]
        public string? HomeState { get; set; }

        [RegularExpression(@"^\d{5}$", ErrorMessage = "Invalid ZIP code format")]
        public string? HomeZip { get; set; }

        public string? OfficeStreet { get; set; }

        public string? OfficeCity { get; set; }

        [StringLength(2)]
        public string? OfficeState { get; set; }

        [RegularExpression(@"^\d{5}$", ErrorMessage = "Invalid ZIP code format")]
        public string? OfficeZip { get; set; }

        public List<string>? FavoriteColors { get; set; }

        public int? Age { get; set; }
    }

}
