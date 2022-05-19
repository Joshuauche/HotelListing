using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Models
{
    // class that represent the bridge between defined entity classes and database
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions options) 
            : base(options)
        {

        }


        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

    }
}
