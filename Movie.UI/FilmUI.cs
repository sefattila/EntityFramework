using Microsoft.EntityFrameworkCore;
using Movie.DAL.Concrete;
using Movie.DAL.Interfaces;
using Movie.DATA.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.UI
{
    public class FilmUI
    {
        FilmDAL _film;
        public FilmUI(DbSet<Film> table, DbContext context)
        {
            _film = new FilmDAL(table, context);
        }
        public void Exe()
        {
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("1. Film Ekle\n" +
                                  "2. Film Güncelle\n" +
                                  "3. Film Sil\n" +
                                  "4. Filmleri Göster\n" +
                                  "5. Çıkış\n" +
                                  "Seçim: ");
                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        Console.Write("Film Adı:");
                        string nameAdd = Console.ReadLine();
                        Console.Write("Film Saati:");
                        double durationAdd = double.Parse(Console.ReadLine());
                        Console.Write("Kategori Id:");
                        int categoryAdd = int.Parse(Console.ReadLine());
                        AddFilm(nameAdd, durationAdd, categoryAdd);
                        break;
                    case "2":
                        Console.Write("Film Id:");
                        int filmIdUp = int.Parse(Console.ReadLine());
                        Console.Write("Film Adı:");
                        string nameUp = Console.ReadLine();
                        Console.Write("Film Saati:");
                        double durationUp = double.Parse(Console.ReadLine());
                        Console.Write("Kategori Id:");
                        int categoryUp = int.Parse(Console.ReadLine());
                        UpdateFilm(filmIdUp, nameUp, durationUp, categoryUp);
                        break;
                    case "3":
                        Console.Write("Film Id:");
                        int filmIdDel = int.Parse(Console.ReadLine());
                        DeleteFilm(filmIdDel);
                        break;
                    case "4":
                        AllFilm();
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

        void AddFilm(string filmName, double duration, int categoryId)
        {
            Film film = new Film() { FilmName = filmName, FilmDuration = duration, CreatedDate = DateTime.Now, CategoryId = categoryId };
            _film.Create(film);
            Console.WriteLine("Eklendi");
        }

        void UpdateFilm(int filmId, string filmName, double duration, int categoryId)
        {
            var update = _film.GetDefault(x => x.Id == filmId);
            if (update != null)
            {
                update.FilmName = filmName;
                update.FilmDuration = duration;
                update.CategoryId = categoryId;
                _film.Update(update);
                Console.WriteLine("Güncellendi");
            }
            else Console.WriteLine("Eşleşen Id Yok");
        }

        void DeleteFilm(int filmId)
        {
            var delete = _film.GetDefault(x => x.Id == filmId);
            if (delete != null)
            {
                _film.Delete(delete);
                Console.WriteLine("Silindi");
            }
            else Console.WriteLine("Eşleşen Id Yok");
        }

        void AllFilm()
        {
            var allFilm = _film.GetFilms();
            foreach (var item in allFilm)
            {
                Console.WriteLine($"Film Id:{item.Id} Film Name:{item.FilmName} Duration:{item.FilmDuration} Category Name:{item.CategoryId}\n");
            }
        }
    }
}
