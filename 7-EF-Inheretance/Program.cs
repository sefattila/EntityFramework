using _7_EF_Inheretance.Context;
using _7_EF_Inheretance.Entities;
using System.Xml.Linq;

namespace _7_EF_Inheretance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                //context.People.Add(new Employee() { AdmissionDate= DateTime.Now,BirthDate=new DateTime(1998,04,06),JobDescription="Engineer",Name="Sefa" }); ;

                //context.People.Add(new Customer() { BirthDate = new DateTime(1999, 03, 15), LastPurchaseDate = DateTime.Now, Name = "Zeynep", TotalVisits =6 });

                //context.Customers.Add(new Customer() { BirthDate = new DateTime(1999, 03, 15), LastPurchaseDate = DateTime.Now, Name = "Ali", TotalVisits = 10 });

                var emp = context.Employees.ToList(); //sadece Employee tablosundaki verileri getirir
                var cus = context.Customers.ToList(); //sadece Customer tablosundaki verileri getirir

                var people = context.People.ToList(); //Her veriyi çeker

                people.ForEach(p =>
                {
                    switch (p)
                    {
                        case Employee employee:
                            Console.WriteLine($"İşçi Adi:{employee.Name}");
                            break;
                        case Customer customer:
                            Console.WriteLine($"Müşteri Adi:{customer.Name}");
                            break;
                        default:
                            break;
                    }
                });


                Console.WriteLine("Başarılı");
            }
        }
    }
}