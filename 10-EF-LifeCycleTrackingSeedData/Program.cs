using _10_EF_LifeCycleTrackingSeedData.Context;
using _10_EF_LifeCycleTrackingSeedData.Models;
using Microsoft.EntityFrameworkCore;

namespace _10_EF_LifeCycleTrackingSeedData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region AsNoTracking

            /*EF'nin select işlemlerinde döndürdüğü detayı cacheleyerek takibe alır.
             * Bunun sebebi datayı güncelleyip SaveChanges metodunu çağırdığımızda değişikliklerin
             * veritabanına yansımasını sağlamaktadır. AsNoTracking() buradaki cash'lere mekanizmasını
             * kaldırarak projenize büyük bir performans katkısında bulunur
             */

            using (var context = new AppDbContext())
            {
                //context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking; genel yapar her tabloyu asnotacking yapar


                var authorsNoTrack = context.Authors.AsNoTracking().ToList();

                var author = new Author() { FirstName = "Ahmet Hamdi", LastName = "Tanpınar" };

                authorsNoTrack.Add(author);

                context.SaveChanges(); //veritabanına eklemeyecek. asnotrackle eklediğim için

                foreach (var item in context.Authors.ToList())
                {
                    Console.WriteLine($"FirstName:{item.FirstName} LastName:{item.LastName}");
                }
            }
            Console.WriteLine("\n*****************************\n");
            #endregion

            #region LifeCycle
            //Entity oluştuğu anda, eklendiğinde, değiştirildiğinde, silindiğinde vb işlemler gerçekleştiğinde entity state dediğimiz kavramda değişir.
            //Bu duruma life cycle denir. Entity state ise entity durumu belirten kavramdır.
            //System.Data.EntityState'de bulunan bir unum nesnesidir

            /*Entity nesnelerin varoluş durumlarına göre şu state yapılarından birini alır;
             *Added: Entity eklendi(added olarak işaretlenir)
             *Deleted: Entity silindi(deleted olarak işaretlenir)
             *Modified: Entity güncellendi(modified olarak işaretlenir)
             *Unchange: Entity güncellenmedi
             *Detached: Entity track edilmedi(untracked)
             */

            //Entity state içerik tarafından otomatik olarak belirklenir, ancak geliştirici tarafından manuel olarak da değiştilebilir.

            using (var context = new AppDbContext())
            {
                //Detached: Henüz context nesnesine set edilmemiş entity
                var author1 = new Author() { FirstName = "Peyami", LastName = "Safa" };
                Console.WriteLine("Yazat 1 Durum:" + context.Entry(author1).State);

                var getAuthor = context.Authors.ToList();
                foreach (var item in getAuthor)
                {
                    Console.WriteLine($"FirsName:{item.FirstName} LastName:{item.LastName}");
                }

                //Added:
                //context.Entry(author1).State = EntityState.Added;
                //Console.WriteLine("Yazar 2 Durum:"+ context.Entry(author1).State);
                //context.SaveChanges();

                //var peyami = context.Authors.FirstOrDefault(a => a.FirstName == "Peyami");
                //Console.WriteLine($"Firstname:{peyami.FirstName} LastName:{peyami.LastName}");

                //Unchanged:
                //var peyami = context.Authors.FirstOrDefault(p => p.FirstName == "Peyami");
                //Console.WriteLine($"Firstname:{peyami.FirstName} LastName:{peyami.LastName}");
                //Console.WriteLine(context.Entry(peyami).State);

                //Modified:
                //peyami.FirstName = "PEYAMI";
                //peyami.LastName = "SEFA";
                //context.Entry(peyami).State = EntityState.Modified;
                //Console.WriteLine(context.Entry(peyami).State);
                //Console.WriteLine($"Firstname:{peyami.FirstName} LastName:{peyami.LastName}");

                //Deleted:
                //context.Entry(peyami).State = EntityState.Deleted;
                //Console.WriteLine(context.Entry(peyami).State);
                //context.SaveChanges();

                //var getAuthor2 = context.Authors.ToList();

                //foreach (var item in getAuthor2)
                //{
                //    Console.WriteLine($"Firstname:{item.FirstName} LastName:{item.LastName}");
                //}
            }
        }

        #endregion
    }
}
