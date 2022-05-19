using System.ComponentModel.DataAnnotations;

namespace HotelListing.Dtos
{
    public class HotelDto : CreateHotelDto
    {
        
        public int HotelId { get; set; }

        public CountryDto Country { get; set; }
    }
}
