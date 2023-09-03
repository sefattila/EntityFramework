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
    public class FilmActorMapping : IEntityTypeConfiguration<FilmActor>
    {
        public void Configure(EntityTypeBuilder<FilmActor> builder)
        {
            builder.Property(x => x.ActorId)
                .IsRequired();

            builder.Property(x=>x.FilmId)
                .IsRequired();

            builder.Property(x=>x.WorkDay)
                .IsRequired(false);

            builder.ToTable("TblFilmActor");

            builder
                .HasOne(x => x.Film)
                .WithMany(x => x.FilmActors)
                .HasForeignKey(x => x.FilmId);

            builder
                .HasOne(x => x.Actor)
                .WithMany(x => x.FilmActors)
                .HasForeignKey(x => x.ActorId);
               
        }
    }
}
