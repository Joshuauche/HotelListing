using System.ComponentModel.DataAnnotations;

namespace HotelListing.Dtos
{
    public class CreateCountryDto
    {
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Country Name is too long")]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 2, ErrorMessage = "Short Name is too long")]
        public string ShortName { get; set; }
    }
}
