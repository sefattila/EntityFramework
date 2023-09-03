using Microsoft.EntityFrameworkCore;
using Movie.DAL.Concrete;
using Movie.DATA.Abstract;
using Movie.DATA.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.UI
{
    public class FilmCategoryUI
    {
        FilmCategoryDAL _filmCategory;
        public FilmCategoryUI(DbSet<FilmCategory> table, DbContext context)
        {
            _filmCategory = new FilmCategoryDAL(table, context);
        }

        public void Exe()
        {
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("1. Kategori Ekle\n" +
                                  "2. Kategori Güncelle\n" +
                                  "3. Kategori Sil\n" +
                                  "4. Kategorileri Göster\n" +
                                  "5. Çıkış\n" +
                                  "Seçim: ");
                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        Console.Write("Kategori Adı:");
                        string categoryName= Console.ReadLine();
                        AddCategory(categoryName);
                        break;
                    case "2":
                        Console.Write("Kategori Id");
                        int categoryId=int.Parse(Console.ReadLine());
                        Console.WriteLine("Kategori Adı");
                        string name=Console.ReadLine();
                        UpdateCategory(categoryId, name);
                        break;
                    case "3":
                        Console.WriteLine("Kategori Id");
                        int id=int.Parse(Console.ReadLine());
                        DeleteCategory(id);
                        break;
                    case "4":
                        AllCategory();
                        break;
                    case "5":
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Geçerli Değer Giriniz");
                        break;
                }
            }
        }

        void AddCategory(string categoryName)
        {
            FilmCategory filmCategory = new FilmCategory() { CategoryName = categoryName, CreatedDate = DateTime.Now };
            _filmCategory.Create(filmCategory);
            Console.WriteLine("Eklendi");
        }

        void UpdateCategory(int categoryId,string categoryName)
        {
            var update=_filmCategory.GetDefault(x=>x.Id==categoryId);
            if(update != null)
            {
                update.CategoryName = categoryName;
                _filmCategory.Update(update);
                Console.WriteLine("Güncellendi");
            }
            else Console.WriteLine("Eşleşen Id Yok");
        }

        void DeleteCategory(int categoryId)
        {
            var delete = _filmCategory.GetDefault(x => x.Id == categoryId);
            if(delete != null)
            {
                _filmCategory.Delete(delete);
                Console.WriteLine("Silindi");
            }
            else Console.WriteLine("Eşleşen Id Yok");
        }

        void AllCategory()
        {
            var allCategory = _filmCategory.Get();
            foreach (var item in allCategory)
            {
                Console.WriteLine($"Category Id:{item.Id} Category Name:{item.CategoryName}\n");
            }
        }
    }
}
