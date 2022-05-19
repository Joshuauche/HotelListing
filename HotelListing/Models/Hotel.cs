using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Models
{
    public class Hotel
    { 
        public int HotelId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Ratings { get; set; }

        [ForeignKey(nameof(CountryId))]
        public Country Country { get; set; }
        public int CountryId { get; set; }

    }
}
