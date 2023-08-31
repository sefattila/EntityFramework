using _9_EF_UniYonetimOrnek.Contexts;
using _9_EF_UniYonetimOrnek.Enums;
using _9_EF_UniYonetimOrnek.Models;
using _9_EF_UniYonetimOrnek.Service.Concrete;

namespace _9_EF_UniYonetimOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                Teacher teacher = new Teacher() { Name = "Ali", CreateDate = DateTime.Now, Status = Status.Active };
                Student student = new Student() { Name = "Sefa", CreateDate = DateTime.Now, Status = Status.Active };
                Course course = new Course()
                {
                    Title = "Matematik",
                    Teacher = teacher,
                    CreateDate = DateTime.Now,
                    Status = Status.Active,
                    Students = new List<Student>() { student }
                };
                context.Add(course);
                context.SaveChanges();
            }
        }
    }
}