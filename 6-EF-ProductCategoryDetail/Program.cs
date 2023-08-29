using _6_EF_ProductCategoryDetail.Context;
using _6_EF_ProductCategoryDetail.Entities;
using _6_EF_ProductCategoryDetail.Enums;
using _6_EF_ProductCategoryDetail.Service.Concrete;

namespace _6_EF_ProductCategoryDetail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CategoryService categoryService = new CategoryService(new AppDbContext());
            //categoryService.Add(new Category() { Name = "Kalem", Status = Statu.Active });

            //var categoryList = categoryService.GetByDefaults(c => c.Name == "Kalem");

            //foreach (var item in categoryList)
            //{
            //    Console.WriteLine($"{item.CategoryId} {item.Name} {item.Status}");
            //}




            //Category category = new Category() { Name = "Kitap", Status = Statu.Active };

            //BaseService<Category> baseService=new BaseService<Category>(new AppDbContext());
            //baseService.Add(category);

            Product product = new Product() { CategoryRefId = 2, Name = "Cin Ali", Price = 80m, Stock = 100, Status = Statu.Active };

            BaseService<Product> baseService1=new BaseService<Product>(new AppDbContext());
            baseService1.Add(product);

            Console.WriteLine("Başşarılı");
        }
    }
}