using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_EF_LifeCycleTrackingSeedData.Models.SeedData
{
    public class SeedBook : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder
                .HasData(
                new Book() { BookId = 1, Title = "Suç ve Ceza", AuthorID = 1 },
                new Book() { BookId = 2, Title = "Karamazoz Kardeşler", AuthorID = 1 },
                new Book() { BookId = 3, Title = "Yeraltından Notlar", AuthorID = 2 },
                new Book() { BookId = 4, Title = "Beyaz Cüceler", AuthorID = 2 }
                );
        }
    }
}
