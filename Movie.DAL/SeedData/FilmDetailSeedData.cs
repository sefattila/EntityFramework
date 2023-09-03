using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Movie.DATA.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.DAL.SeedData
{
    public class FilmDetailSeedData : IEntityTypeConfiguration<FilmDetail>
    {
        public void Configure(EntityTypeBuilder<FilmDetail> builder)
        {
            builder.HasData
                (
                    new FilmDetail() { Id = 1, FilmDetails = "DenemeDenemeDeneme", FilmId = 1, CreatedDate = DateTime.Now },
                    new FilmDetail() { Id = 2, FilmDetails = "DenemeDenemeDeneme", FilmId = 2, CreatedDate = DateTime.Now },
                    new FilmDetail() { Id = 3, FilmDetails = "DenemeDenemeDeneme", FilmId = 3, CreatedDate = DateTime.Now },
                    new FilmDetail() { Id = 4, FilmDetails = "DenemeDenemeDeneme", FilmId = 4, CreatedDate = DateTime.Now }
                );
        }
    }
}
