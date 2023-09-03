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
    public class FilmSeedData : IEntityTypeConfiguration<Film>
    {
        public void Configure(EntityTypeBuilder<Film> builder)
        {
            builder.HasData
                (
                    new Film() { Id = 1, FilmName = "Cath Me If You Can", FilmDuration = 2.5, CategoryId = 1, CreatedDate = DateTime.Now },
                    new Film() { Id = 2, FilmName = "Forest Gump", FilmDuration = 3, CategoryId = 1, CreatedDate = DateTime.Now },
                    new Film() { Id = 3, FilmName = "Inception", FilmDuration = 2, CategoryId = 3, CreatedDate = DateTime.Now },
                    new Film() { Id = 4, FilmName = "The Green Mile", FilmDuration = 2.3, CategoryId = 1, CreatedDate = DateTime.Now }
                );
        }
    }
}
