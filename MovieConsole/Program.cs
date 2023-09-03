using Microsoft.EntityFrameworkCore;
using Movie.DAL.Contexts;
using Movie.DATA.Concrete;
using Movie.UI;

namespace MovieConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FilmCategory filmCategory= new FilmCategory();
            //filmCategory.CategoryName = "Fıstıkçı Şahap";
            //Console.WriteLine(filmCategory.CategoryURL);
            using (var context = new FilmContext())
            {
                FilmCategoryUI filmCategoryUI = new FilmCategoryUI(context.Set<FilmCategory>(),context);

                filmCategoryUI.Exe();
            }
        }
    }
}