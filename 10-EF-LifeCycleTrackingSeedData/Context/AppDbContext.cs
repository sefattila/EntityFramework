using _10_EF_LifeCycleTrackingSeedData.Models;
using _10_EF_LifeCycleTrackingSeedData.Models.SeedData;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_EF_LifeCycleTrackingSeedData.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=KDK-403-PC13-YZ;Database=SeedDataDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Seed Data, genellikle veritabanı ilk oluşturulduğunda verileri veri tabanına ekleme süreci olarak ifade edilir.
            //I.Yol
            modelBuilder.Entity<Author>()
                .HasData(
                new Author() { AuthorId = 1, FirstName = "William", LastName = "Shaksper" },
                new Author() { AuthorId = 2, FirstName = "Fyoder", LastName = "Dostoyevski" }
                );

            //II.Yol
            modelBuilder.ApplyConfiguration(new SeedBook());


            base.OnModelCreating(modelBuilder);
        }

    }
}
