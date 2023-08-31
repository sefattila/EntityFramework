using _7_EF_Inheretance.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_EF_Inheretance.Context
{
    public class AppDbContext : DbContext
    {
        #region TPH
        //bu yaklaşım tüm kalıtım yapısını temsil etmek için veritabanında tek bir tablo oluşturacaktır.
        public DbSet<BasePerson> People { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }

        //Avantajları
        //Joine gerek yok,ancak bir çok sutun için veritabanı bir çok disk belleği işlemi gerçekleştirir
        //Kullanımı oluştuması kolay

        //Dezavantajlar
        //3rd Normal Form ihlal edilir
        //Null veriler olucak tabloda

        #endregion

        #region TPT
        /*Bu yaklaşım tüm kalıtım yapısını temsil etymek için veritabanında (n) aden (n-subclass) tablo oluşturacaktır
         * 
         * Avantajları
         * Normalize Tablolar
         * Kolay kolon ekleme
         * Az sayıda null kolon 
         */

        //public DbSet<Customer> Customers { get; set; }
        //public DbSet<Employee> Employees { get; set; }

        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=KDK-403-PC13-YZ;Database=InheretanceDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
