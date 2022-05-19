using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Dtos
{
    public class CountryDto : CreateCountryDto
    {
        public int CountryId { get; set; }

        public IList<HotelDto> Hotels { get; set; }

    }
}
