using _5_EF_CodeFirstModelDbContextDbSet.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//add-migration initialCatolog
namespace _5_EF_CodeFirstModelDbContextDbSet.Context
{
    //DbContext: Verilerle nesneler olarak etkileşim kurmaktan sorumlu olan birincil sınıftır.System.Data.Entity.DbContext
    //DbContext api .netframeworkun bişr parçası olarak yayınlanmaz. 
    //Entityframework.dll dosyası NuGet Package aracılığı ile gelir
    public class AppDbContext : DbContext
    {
        //DbSet: Model içindeki belirli bir entity için koleksiyonu temsil eder. Bir entitye karşı veritabanına açılan ağ geçitidir.
        //DbSet<Entity> sınıfları, DbContext'e özellik olarak eklenir ve varsayılan olarak DbSet<Entity> özelliğinin adını alan veritabanı tablolarıyla eşlenir
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        //SQL Configüreasyonlarını yaptığım metot
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=KDK-403-PC13-YZ;Database=Book;Trusted_Connection=True;");
        }

        //tablolarımızın Fluent Apı kullanrak özelleştirdiğimiz yer
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
