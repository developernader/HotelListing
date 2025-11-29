using HotelListing.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Configurations.Entities
{
    public class HotelConfiguation : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
                 new Hotel { Id = 1, Name = "Fairmont Nile City", Address = "1191 Nile Corniche, Souq Al ASR", CountryId = 1, Rating = 8.4 },
                new Hotel { Id = 2, Name = "Comfort Suites", Address = "George Town", CountryId = 3, Rating = 4.3 },
                new Hotel { Id = 3, Name = "Sandals Resort and Spa", Address = "CI", CountryId = 3, Rating = 4.5 }
                );
        }
    }
}
