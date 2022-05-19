using System;
using System.ComponentModel.DataAnnotations;

namespace HotelListing.Dtos
{
    public class CreateHotelDto
    {
        [Required]
        [StringLength(maximumLength: 150, ErrorMessage = "Hotel name is too long")]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 250, ErrorMessage = "Hotel Address is too long")]
        public string Address { get; set; }

        [Required]
        [Range(1, 5)]
        public double Ratings { get; set; }

        [Required]
        public int CountryId { get; set; }
    }
}
