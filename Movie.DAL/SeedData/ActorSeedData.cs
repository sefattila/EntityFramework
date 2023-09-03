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
    public class ActorSeedData : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> builder)
        {
            builder.HasData(
                new Actor() { Id = 1, ActorName = "Leonardo DiCaprio", CreatedDate = DateTime.Now },
                new Actor() { Id = 2, ActorName = "Tom Hanks", CreatedDate = DateTime.Now },
                new Actor() { Id = 3, ActorName = "Michael Clarke Duncan", CreatedDate = DateTime.Now },
                new Actor() { Id = 4, ActorName = "Tom Hardy", CreatedDate = DateTime.Now }
                );
        }
    }
}
