using Microsoft.EntityFrameworkCore;
using Movie.DAL.Mapping;
using Movie.DAL.SeedData;
using Movie.DATA.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.DAL.Contexts
{
    public class FilmContext : DbContext
    {
        public DbSet<Actor> Actors { get; set; }
        public DbSet<FilmCategory> FilmCategories { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<FilmDetail> FilmDetails { get; set; }
        public DbSet<FilmActor> FilmActors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer("Server=KDK-403-PC13-YZ;Database=MovieDB;Trusted_Connection=True;");
            //optionsBuilder.UseSqlServer("Server=DESKTOP-LAUF8V8;Database=MovieDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //hazır veri
            modelBuilder.ApplyConfiguration(new ActorSeedData());
            modelBuilder.ApplyConfiguration(new FilmActorSeedData());
            modelBuilder.ApplyConfiguration(new FilmCategorySeedData());
            modelBuilder.ApplyConfiguration(new FilmDetailSeedData());
            modelBuilder.ApplyConfiguration(new FilmSeedData());

            //fluent api
            modelBuilder.ApplyConfiguration(new ActorMapping());
            modelBuilder.ApplyConfiguration(new FilmActorMapping());
            modelBuilder.ApplyConfiguration(new FilmCategoryMapping());
            modelBuilder.ApplyConfiguration(new FilmDetailMapping());
            modelBuilder.ApplyConfiguration(new FilmMapping());
        }
    }
}
