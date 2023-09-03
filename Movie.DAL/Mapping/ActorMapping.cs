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
    public class ActorMapping : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> builder)
        {
            builder.Property(x=>x.ActorName).IsRequired();
            builder.Property(x=>x.BirthDate).IsRequired(false);
            builder.Property(x => x.Biography)
                .IsRequired(false)
                .HasColumnType("text");
            builder.ToTable("TblActor");
        }
    }
}
