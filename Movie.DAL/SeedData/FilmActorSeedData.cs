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
    public class FilmActorSeedData : IEntityTypeConfiguration<FilmActor>
    {
        public void Configure(EntityTypeBuilder<FilmActor> builder)
        {
            builder.HasData
                (
                    new FilmActor() { Id = 1, CreatedDate = DateTime.Now, FilmId = 1, ActorId = 1 },
                    new FilmActor() { Id = 2, CreatedDate = DateTime.Now, FilmId = 1, ActorId = 2 },
                    new FilmActor() { Id = 3, CreatedDate = DateTime.Now, FilmId = 2, ActorId = 2 },
                    new FilmActor() { Id = 4, CreatedDate = DateTime.Now, FilmId = 3, ActorId = 1 },
                    new FilmActor() { Id = 5, CreatedDate = DateTime.Now, FilmId = 3, ActorId = 4 },
                    new FilmActor() { Id = 6, CreatedDate = DateTime.Now, FilmId = 4, ActorId = 2 },
                    new FilmActor() { Id = 7, CreatedDate = DateTime.Now, FilmId = 4, ActorId = 3 }
                );
        }
    }
}
