using _5_EF_CodeFirstModelDbContextDbSet.Context;
using _5_EF_CodeFirstModelDbContextDbSet.Entities;
using Microsoft.EntityFrameworkCore;

namespace _5_EF_CodeFirstModelDbContextDbSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add();
            Read();
            //Update();
            //Remove();
        }
        static void Add()
        {
            //Author author = new Author() { FirstName = "Sefa", LastName = "Attila" };
            //using(var context=new AppDbContext())
            //{
            //    context.Authors.Add(author);
            //    context.SaveChanges();
            //}

            using (var context = new AppDbContext())
            {
                var author = context.Authors.Find(1);
                //Book book = new Book() { Title = "Coding 101", Subject = "C#,SQL,Entity", AuthorId=author.AuthorId};
                //Book book= new Book() { Title="Coding 101",Subject="C#,SQL,Entity",AuthorId=1};
                //context.Books.Add(book); //nesne içinde de yazabilirim
                //context.SaveChanges();

                //Book book = new Book() { Title = "Attila", Subject = "Kırbaç", Author= author }; //direkt nesneyi verdik
                //context.Books.Add(book); //nesne içinde de yazabilirim
                //context.SaveChanges();

                //Author author1 = new Author() { FirstName = "Ahmet", LastName = "Ümit" };
                //Book book = new Book() { Title = "Sultanı Öldürmek", Subject = "Polisiye", Author = author1 };
                //context.Books.Add(book);
                //context.SaveChanges();

                //List<Book> books = new List<Book>() { new Book() { Title = "Deneme", Subject = "Kırbaç"} };
                //Author author1 = new Author() { FirstName = "Ali", LastName = "Küçük", Books = books };
                //context.Add(author1);
                //context.SaveChanges();
            }
        }
        static void Read()
        {
            //Read Entity with Single
            //using ( var context=new AppDbContext()) //garbage collectoru yönetmek için iş bittiğinde silsin
            //{
            //    var author1=context.Authors.Single(a => a.AuthorId==1);
            //    Console.WriteLine($"Yazar Adı:{author1.FirstName} {author1.LastName}");

            //    var author2=context.Authors.FirstOrDefault(a => a.AuthorId==1);
            //    if (author2 != null)
            //    {
            //        Console.WriteLine($"Adi: {author2.FirstName} {author2.LastName}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Yok");
            //    }

            //    //Read entity with Find
            //    var author3=context.Authors.Find(1); //primary ley karşılığı
            //    Console.WriteLine($"Adi: {author3.FirstName} {author3.LastName}");

            //    var author4 = context.Authors.ToList();
            //    foreach (var item in author4)
            //    {
            //        Console.WriteLine($"Ad:{item.FirstName} {item.LastName} ID:{item.AuthorId}");
            //    }
            //}

            //using (var context = new AppDbContext())
            //{
            //    var getir = context.Books
            //        .Join(
            //        context.Authors,
            //        book => book.AuthorId,
            //        author => author.AuthorId,
            //        (book, author) => new
            //        {
            //            Book = book,
            //            Ad = author.FirstName,
            //            Soyad = author.LastName,
            //        }
            //        ).GroupBy(author => author.Ad)
            //         .Select(group => new
            //         {
            //             YazarAd = group.Key,
            //             Book = group.Select(book => book.Book).ToList()
            //         }
            //            );

            //    foreach (var item in getir)
            //    {
            //        Console.WriteLine($"{item.YazarAd}");
            //        foreach (var item2 in item.Book)
            //        {
            //            Console.WriteLine($"    {item2.Title}");
            //        }
            //    }

            //    //var innerJoin = context.Authors.Join(
            //    //    context.Books,
            //    //    a => a.AuthorId,
            //    //    b => b.AuthorId,
            //    //    (a, b) => new
            //    //    {
            //    //        a.FirstName,
            //    //        a.LastName,
            //    //        b.Title
            //    //    }
            //    //    );
            //    //foreach (var item in innerJoin)
            //    //{
            //    //    Console.WriteLine($"{item.FirstName} {item.LastName} Kitap:{item.Title}");
            //    //}
            //}

            //Eager Loading(ileri yükleme)
            /*İlişkili verilere ihtiyaç duyulduğunda yüklenir. Eager loading de ilişkili nesneleri yüklemesi
             * ilk başta yüklü olarak gelir. Bu da gereksiz veya fazladan yükleme yapmamıza sebep olur.
             */

            using (var context = new AppDbContext())
            {
                var bookWithAuthor = context.Books.Include(b=>b.Author).ToList(); //eager loading
                foreach (var book in bookWithAuthor)
                {
                    Console.WriteLine($"Kitap Adi:{book.Title} Yazar Adi:{book.Author.FirstName}");
                }
            }

            Console.WriteLine("****************************************");

            //lazy loading(tembel yükleme)
            //ilk yüklemede  ana nesne yüklenir. İhtiyacım olduğu anda ilişkili nesne yüklemesi gerçekleşir.
            //daha performanslı
            /* 1- paket yükle
             * 2- onConfiguraiton içinde tanımla
             * 3- navigation propları virtaul işaretle
             */

            using (var context=new AppDbContext())
            {
                var books = context.Books.ToList();
                foreach (var item in books)
                {
                    Console.WriteLine($"Kitap Adi:{item.Title} Yazar Adi:{item.Author.FirstName}");
                }
            }
        }

        static void Update()
        {
            using (var context = new AppDbContext())
            {
                var authorUp = context.Authors.Find(2);
                authorUp.FirstName = "Fatih";
                authorUp.LastName = "Alkan";

                //context.Authors.Update(authorUp);
                context.SaveChanges();

                var authorGetir = context.Authors.Find(2);
                Console.WriteLine($"Yazar Adı:{authorGetir.FirstName} {authorGetir.LastName} {authorGetir.AuthorId}");
            }
        }

        static void Remove()
        {
            using (var context = new AppDbContext())
            {
                context.Remove(context.Authors.Find(2));
                context.SaveChanges();
            }
        }
    }
}