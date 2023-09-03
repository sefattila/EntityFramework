using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Movie.DATA.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.DAL.Mapping
{
    public class FilmMapping : IEntityTypeConfiguration<Film>
    {
        public void Configure(EntityTypeBuilder<Film> builder)
        {
            builder.Property(x => x.FilmName)
                .IsRequired()
                .HasColumnType("nvarchar(50)");

            builder.Property(x => x.FilmDuration)
                .IsRequired();

            builder.Property(x => x.PublishDate) 
                .IsRequired(false);

            builder.ToTable("TblFilm");

            builder
                .HasOne(x => x.FilmCategory)
                .WithMany(x => x.Films)
                .HasForeignKey(x => x.CategoryId);
        }
    }
}
