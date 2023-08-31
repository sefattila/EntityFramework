using _8_EF_DataAnnotationAndFluentApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_EF_DataAnnotationAndFluentApi.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=KDK-403-PC13-YZ;Database=BookAuthorDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Column
            modelBuilder.Entity<Book>()
                .Property(p => p.BookName)
                .HasColumnName("ClmBookName")
                .HasColumnOrder(2)
                .HasColumnType("nvarchar")
                .IsRequired(required: false);

            //ConcurrencyCheck
            modelBuilder.Entity<Author>()
                .Property(a => a.AuthorName)
                .IsConcurrencyToken();

            //Key
            modelBuilder.Entity<Book>()
                .HasKey(a => a.BookId);

            //Composit Key
            modelBuilder.Entity<Book>()
                .HasKey(a => new
                {
                    a.BookId,
                    a.Author.AuthorId
                });

            //maxlength
            modelBuilder.Entity<Book>()
                .Property(b => b.BookSubject)
                .HasMaxLength(128);

            //Table
            modelBuilder.Entity<Author>()
                .ToTable("TblYazar");

            //NotMapped Class
            modelBuilder.Ignore<Deneme>();

            //NotMapped Column
            modelBuilder.Entity<Author>()
                .Ignore(a => a.AuthorAge);

            modelBuilder.Entity<Author>()
                .HasMany(a => a.Books)
                .WithOne(b => b.Author)
                .HasForeignKey(b => b.AuthorFKId);
                
        }
    }
}
