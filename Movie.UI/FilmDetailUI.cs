using Microsoft.EntityFrameworkCore;
using Movie.DAL.Concrete;
using Movie.DATA.Concrete;
using Movie.DATA.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Movie.UI
{
    public class FilmDetailUI
    {
        private FilmDetailDAL _filmDetail;

        public FilmDetailUI(DbSet<FilmDetail> table, DbContext context)
        {
            _filmDetail = new FilmDetailDAL(table, context);
        }
        public void Exe()
        {
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("1. Detay Ekle\n" +
                                  "2. Detay Güncelle\n" +
                                  "3. Detay Sil\n" +
                                  "4. Detayları Göster\n" +
                                  "5. Çıkış\n" +
                                  "Seçim: ");
                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        Console.Write("Detay Adı:");
                        string detayAdd = Console.ReadLine();
                        Console.Write("Film Id:");
                        int filmAdd = int.Parse(Console.ReadLine());

                        break;
                    case "2":
                        Console.Write("Detay Id:");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Detay Adı:");
                        string detayUp = Console.ReadLine();
                        Console.Write("Film Id:");
                        int filmUp = int.Parse(Console.ReadLine());

                        break;
                    case "3":
                        Console.Write("Aktör Id:");
                        int detayDel = int.Parse(Console.ReadLine());
                        Delete(detayDel);
                        break;
                    case "4":
                        All();
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

        void Add(string detay, int filmId)
        {
            FilmDetail filmDetail = new FilmDetail() { FilmDetails = detay, FilmId = filmId, CreatedDate = DateTime.Now };
            _filmDetail.Create(filmDetail);
            Console.WriteLine("Eklendi");
        }

        void Update(int id, string detay, int filmId)
        {
            var update = _filmDetail.GetDefault(x => x.Id == id);
            if (update != null)
            {
                update.FilmDetails = detay;
                update.FilmId = filmId;
                update.UpdatedDate = DateTime.Now;
                update.Status = Status.Modified;
                _filmDetail.Update(update);
                Console.WriteLine("Güncellendi");
            }
            else Console.WriteLine("Eşleşen Id Yok");
        }

        void Delete(int id)
        {
            var delete = _filmDetail.GetDefault(x => x.Id == id);
            if (delete != null)
            {
                _filmDetail.Delete(delete);
                Console.WriteLine("Silindi");
            }
            else Console.WriteLine("Eşleşen Id Yok");
        }

        void All()
        {
            var allDetail = _filmDetail.Get();
            foreach (var item in allDetail)
            {
                Console.WriteLine($"Detay Id:{item.Id} Film Detay:{item.FilmDetails} Film Id:{item.FilmId}");
            }
        }
    }
}
