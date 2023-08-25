using _5_EF_CodeFirstModelDbContextDbSet.Context;
using _5_EF_CodeFirstModelDbContextDbSet.Entities;

namespace _5_EF_CodeFirstModelDbContextDbSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();
        }
        static void Add()
        {
            Author author = new Author() { FirstName = "Sefa", LastName = "Attila" };
            using(var context=new AppDbContext())
            {
                context.Authors.Add(author);
                context.SaveChanges();
            }
        }
    }
}