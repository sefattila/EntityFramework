using _9_EF_UniYonetimOrnek.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_EF_UniYonetimOrnek.Contexts
{
    public class AppDbContext:DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        //public DbSet<StudentCourse> StudentCourses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=KDK-403-PC13-YZ;Database=UniDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .Property(s => s.Name)
                .HasColumnType("nvarchar(50)");

            modelBuilder.Entity<Student>()
                .HasMany(s => s.Courses)
                .WithMany(c => c.Students).UsingEntity(j => j.ToTable("StudentCourse"));

            modelBuilder.Entity<Teacher>()
                .HasOne(a => a.Course)
                .WithOne(b => b.Teacher)
                .HasForeignKey<Course>(a => a.TeacherId)
                .OnDelete(DeleteBehavior.NoAction);
            
            //setnull:silindiğinde değeri null yap
            //DeleteBehavior.Cascade: ilişki var silemezsin
            //onupdate durumuda var one to many de yapabilirim
            
            //modelBuilder.Entity<StudentCourse>().HasKey(sc => new { sc.StudentId, sc.CourseId });
        }
    }
}
