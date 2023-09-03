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
    public class FilmCategorySeedData : IEntityTypeConfiguration<FilmCategory>
    {
        public void Configure(EntityTypeBuilder<FilmCategory> builder)
        {
            builder.HasData(
                new FilmCategory() { Id = 1, CategoryName = "Drama", CreatedDate = DateTime.Now },
                new FilmCategory() { Id = 2, CategoryName = "Action", CreatedDate = DateTime.Now },
                new FilmCategory() { Id = 3, CategoryName = "Science Fiction", CreatedDate = DateTime.Now },
                new FilmCategory() { Id = 4, CategoryName = "Comedy", CreatedDate = DateTime.Now }
                );
        }
    }
}
