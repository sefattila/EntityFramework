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
    public class FilmActorUI
    {
        private FilmActorDAL _filmActor;

        public FilmActorUI(DbSet<FilmActor> _table, DbContext context)
        {
            _filmActor = new FilmActorDAL(_table, context);
        }
        public void Exe()
        {
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("1. Ekle\n" +
                                  "2. Güncelle\n" +
                                  "3. Sil\n" +
                                  "4. Göster\n" +
                                  "5. Çıkış\n" +
                                  "Seçim: ");
                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        Console.Write("Aktör Adı:");
                        int actorAdd = int.Parse(Console.ReadLine());
                        Console.Write("Aktör Biyografi:");
                        int filmAdd = int.Parse(Console.ReadLine());
                        Add(actorAdd, filmAdd);
                        break;
                    case "2":
                        Console.Write("Film Aktör Id:");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Aktör Adı:");
                        int actorUp = int.Parse(Console.ReadLine());
                        Console.Write("Aktör Biyografi:");
                        int filmUp = int.Parse(Console.ReadLine());
                        Update(id, actorUp, filmUp);
                        break;
                    case "3":
                        Console.Write("Film Aktör Id:");
                        int del = int.Parse(Console.ReadLine());
                        Delete(del);
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

        void Add(int actor, int film)
        {
            FilmActor filmActor = new FilmActor() { ActorId = actor, FilmId = film ,CreatedDate=DateTime.Now};
            _filmActor.Create(filmActor);
            Console.WriteLine("Eklendi");
        }

        void Update(int id, int actor, int film)
        {
            var update = _filmActor.GetDefault(x => x.Id == id);
            if (update != null)
            {
                update.ActorId = actor;
                update.FilmId = film;
                update.UpdatedDate = DateTime.Now;
                update.Status = Status.Modified;
                _filmActor.Update(update);
                Console.WriteLine("Güncellendi");
            }
            else Console.WriteLine("Eşleşen Id Yok");
        }

        void Delete(int id)
        {
            var delete = _filmActor.GetDefault(x => x.Id == id);
            if (delete != null)
            {
                _filmActor.Delete(delete);
                Console.WriteLine("Silindi");
            }
            else Console.WriteLine("Eşleşen Id Yok");
        }

        void All()
        {
            var allFilmActor = _filmActor.Get();
            foreach (var item in allFilmActor)
            {
                Console.WriteLine($"Id:{item.Id} Aktör Id:{item.ActorId} Film Id:{item.FilmId}");
            }
        }
    }
}
