using Microsoft.EntityFrameworkCore;
using Movie.DAL.Concrete;
using Movie.DATA.Concrete;
using Movie.DATA.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.UI
{
    public class ActorUI
    {
        private ActorDAL _actor;

        public ActorUI(DbSet<Actor> table,DbContext context)
        {
            _actor = new ActorDAL(table,context);
        }
        public void Exe()
        {
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("1. Aktör Ekle\n" +
                                  "2. Aktör Güncelle\n" +
                                  "3. Aktör Sil\n" +
                                  "4. Aktörleri Göster\n" +
                                  "5. Çıkış\n" +
                                  "Seçim: ");
                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        Console.Write("Aktör Adı:");
                        string nameAdd = Console.ReadLine();
                        Console.Write("Aktör Biyografi:");
                        string bioAdd = Console.ReadLine();
                        AddActor(nameAdd, bioAdd);
                        break;
                    case "2":
                        Console.Write("Aktör Id:");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Aktör Adı:");
                        string nameUp = Console.ReadLine();
                        Console.Write("Aktör Biyografi:");
                        string bioUp = Console.ReadLine();
                        UpdateActor(id, nameUp, bioUp);
                        break;
                    case "3":
                        Console.Write("Aktör Id:");
                        int actorDel = int.Parse(Console.ReadLine());
                        DeleteActor(actorDel);
                        break;
                    case "4":
                        AllActor();
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

        void AddActor(string actorName, string biography)
        {
            Actor actor = new Actor() { ActorName = actorName, Biography = biography, CreatedDate = DateTime.Now };
            _actor.Create(actor);
            Console.WriteLine("Eklendi");
        }

        void UpdateActor(int actorId, string actorName, string biography)
        {
            var update = _actor.GetDefault(x => x.Id == actorId);
            if (update != null)
            {
                update.ActorName = actorName;
                update.Biography = biography;
                update.UpdatedDate = DateTime.Now;
                update.Status = Status.Modified;
                _actor.Update(update);
                Console.WriteLine("Güncellendi");
            }
            else Console.WriteLine("Eşleşen Id Yok");
        }

        void DeleteActor(int actorId)
        {
            var delete = _actor.GetDefault(x => x.Id == actorId);
            if (delete != null)
            {
                _actor.Delete(delete);
                Console.WriteLine("Silindi");
            }
            else Console.WriteLine("Eşleşen Id Yok");
        }

        void AllActor()
        {
            var allActor = _actor.GetActors();
            foreach (var item in allActor)
            {
                Console.WriteLine($"Film Id:{item.Id} Film Name:{item.ActorName} Duration:{item.Biography}");
            }
        }
    }
}
