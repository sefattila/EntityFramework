using System.Collections.Concurrent;

namespace _2_EF_LinqQuary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Query Syntax Sorgu
             * Veri tabanına sorgu yazmak için T-SQL komutlarına benzer c# için tanımlanan sorgu komutlarıdır
             */
            //collection -IEnumarable, IQuerable, IList list kavramlarını araştırınız
            IList<Person> personList = new List<Person>()
            {
                new Person()
                {
                    PersonId= 1,
                    PersonName="Sefa",
                    PersonAge=25,
                    PersonCity="Kastamonu"
                },
                new Person()
                {
                    PersonId= 2,
                    PersonName="John",
                    PersonAge=30,
                    PersonCity="NY"
                },
                new Person()
                {
                    PersonId= 3,
                    PersonName="ali",
                    PersonAge=35,
                    PersonCity="London"
                }
            };

            //linq query syntax: Sorgu dizimi from anahtar kelimesi ile başlar ve select anahtar kelimsei ile biter
            #region Select

            // select * from Person
            var select1 = from p in personList select p;

            //select PersonName,PersonCity From Person
            var selectColumn1 = from p in personList select new { p.PersonName, p.PersonCity };

            foreach (var person in select1)
            {
                Console.WriteLine($"Query Syntax ID:{person.PersonId} Name:{person.PersonName} Age:{person.PersonAge} City:{person.PersonCity}");
            }

            foreach (var person in selectColumn1)
            {
                Console.WriteLine($"Query Syntax Name:{person.PersonName} City:{person.PersonCity}");
            }

            //Method Syntax
            //SELECT * FROM Person
            var select2 = personList.ToList();

            foreach (var person in select1)
            {
                Console.WriteLine($"Method Syntax ID:{person.PersonId} Name:{person.PersonName} Age:{person.PersonAge} City:{person.PersonCity}");
            }

            //select PersonName,PersonCity From Person
            var selectColumn2 = personList.Select(p => new { p.PersonName, p.PersonCity });
            foreach (var person in selectColumn2)
            {
                Console.WriteLine($"Method Syntax Name:{person.PersonName} City:{person.PersonCity}");
            }
            #endregion
            Console.WriteLine("\n*********************************\n");
            #region Where
            //Query Syntax
            var where1 = from p in personList where p.PersonName == "Sefa" select p;
            foreach (var item in where1)
            {
                Console.WriteLine($"Query Syntax Where=> Name: {item.PersonName} Age:{item.PersonAge}");
            }

            //Method Syntax
            var where2 = personList.Where(p => p.PersonAge >= 29 && p.PersonAge <= 40);
            foreach (var item in where2)
            {
                Console.WriteLine($"Method Syntax Where=> Name: {item.PersonName} Age:{item.PersonAge}");
            }
            #endregion
            Console.WriteLine("\n*********************************\n");
            #region OrderBy
            //query
            var orderBy1 = from p in personList orderby p.PersonName select p;
            var orderByDesc1 = from p in personList orderby p.PersonName descending select p;

            //method
            var orderBy2 = personList.OrderBy(p => p.PersonName);
            var orderByDesc2 = personList.OrderByDescending(p => p.PersonName);
            #endregion
            Console.WriteLine("\n*********************************\n");
            #region GroupBy
            var groupBy1 = from p in personList group p by p.PersonAge;
            var groupBy2 = personList.GroupBy(p => p.PersonAge);
            #endregion
            Console.WriteLine("\n*********************************\n");
            #region Any
            //Any, herhangi bir elemanın verilen koşulu sağlayıp sağlamadığını kontrol eder.
            bool any1 = personList.Any(p => p.PersonCity == "London");
            Console.WriteLine(any1);
            #endregion
            Console.WriteLine("\n*********************************\n");
            #region Constains
            //Koleksiyonda belirtilen bir öğenin var olup olmadığını kontrol eder
            Person person1 = new Person()
            {
                PersonId = 3,
                PersonName = "Sefa",
                PersonAge = 35,
                PersonCity = "London"
            };
            bool constains1 = personList.Contains(person1);
            Console.WriteLine(constains1);
            #endregion
            Console.WriteLine("\n*********************************\n");
            #region Avarage
            var avg = personList.Average(p => p.PersonAge);
            Console.WriteLine(avg);
            #endregion
            Console.WriteLine("\n*********************************\n");
            #region Count
            var count = personList.Count();
            Console.WriteLine(count);
            #endregion
            Console.WriteLine("\n*********************************\n");
            #region MaxMin
            var max = personList.Max(p => p.PersonAge);
            var min = personList.Min(p => p.PersonAge);
            #endregion
            Console.WriteLine("\n*********************************\n");
            #region Sum
            var sum = personList.Sum(p => p.PersonId);
            #endregion
            Console.WriteLine("\n*********************************\n");
            #region Take
            //Take,ilk öğeden başlayarak belirtilen sayıda öğeyi döndürür.
            var take = personList.Take(1);
            foreach (var item in take)
            {
                Console.WriteLine(item.PersonName);
            }
            Console.WriteLine("**************************************");
            //TakeWhile, belirtilen koşul doğru olana kadar öğeleri döndürür.
            var takeWhile = personList.TakeWhile(p => p.PersonCity == "Kastamonu"); //london dersem çalışmayacak
            foreach (var item in takeWhile)
            {
                Console.WriteLine($"{item.PersonName} {item.PersonCity}");
            }
            #endregion
            Console.WriteLine("\n*********************************\n");
            #region Skip
            var skip = personList.Skip(1);
            foreach (var item in skip)
            {
                Console.WriteLine(item.PersonName);
            }
            #endregion
            Console.WriteLine("\n*********************************\n");
            #region First-FirstOrDefault
            //First, bir koleksiyonun ilk öğesini veya bir koşulu karşılayan ilk öğeyi döndür
            //FirsOrDefault, bir koleksiyonun ilk öğesini veya bir koşulu karşılayan ilk öğeyi döndür yalnız index aralığın dışında ise
            //default değer döndürür
            var first1 = personList.First();
            Console.WriteLine(first1.PersonName);

            var first2 = personList.First(p => p.PersonName == "Sefa");
            Console.WriteLine(first2.PersonName + " " + first2.PersonId);

            var first3 = personList.FirstOrDefault();
            var first4 = personList.FirstOrDefault(p => p.PersonName == "Sefa"); //ahmet yap
            Console.WriteLine($"First:{first4.PersonName} {first4.PersonId}");
            #endregion
            Console.WriteLine("\n*********************************\n");
            #region Last-LastOrDefault
            //Last, bir koleksiyonun ilk öğesini veya bir koşulu karşılayan ilk öğeyi döndür
            //LastOrDefault, bir koleksiyonun ilk öğesini veya bir koşulu karşılayan ilk öğeyi döndür yalnız index aralığın dışında ise
            //default değer döndürür
            var last1 = personList.First();
            Console.WriteLine(last1.PersonName);

            var last2 = personList.First(p => p.PersonName == "Sefa");
            Console.WriteLine(last2.PersonName + " " + first2.PersonId);

            var last3 = personList.LastOrDefault();
            var last4 = personList.LastOrDefault(p => p.PersonName == "Sefa"); //ahmet yap
            Console.WriteLine($"Last:{last3.PersonName} {last4.PersonId}");
            #endregion
            Console.WriteLine("\n*********************************\n");
            #region Single-SingleOrDefault
            //Single, bir koleksiyondaki tek öğeyi veya bir koşulau karşılayan tek öğeyi döndürür. Eğer bulamazsa InvalidOperationException hatası verir
            //var single1 = personList.Single();
            var single2 = personList.Single(p => p.PersonName == "Sefa");
            Console.WriteLine($"Single: {single2.PersonName} {single2.PersonId}"); //iki adet veri olsaydı sefa adında hata vericekti
            #endregion
            Console.WriteLine("\n*********************************\n");
            #region Join
            List<Student> studentList = new List<Student>()
            {
                new Student(){StudentId=1,StudentName="Elif",StandartId=1},
                new Student(){StudentId=2,StudentName="Fevzi",StandartId=1},
                new Student(){StudentId=3,StudentName="Naime",StandartId=1},
                new Student(){StudentId=4,StudentName="Yasin",StandartId=2},
                new Student(){StudentId=5,StudentName="Mehmet Ali",StandartId=2},
            };
            List<Standart> standarts = new List<Standart>()
            {
                new Standart(){StandartId=1,StandartName="Standart 1"},
                new Standart(){StandartId=2,StandartName="Standart 2"},
                new Standart(){StandartId=3,StandartName="Standart 3"}
            };
            //method
            var innerJoin1 = studentList.Join(
                standarts, //inner join
                student => student.StandartId, //outerKeySelector
                standart => standart.StandartId, //innerKeySelectyor
                (student, standart) => new
                {
                    StudentName = student.StudentName,
                    StandartName = standart.StandartName
                });

            foreach (var item in innerJoin1)
            {
                Console.WriteLine($"Method=> Student Name:{item.StudentName}, Standart Name:{item.StandartName}");
            }

            //query
            var innerJoin2 = from student in studentList
                             join standart in standarts
                             on student.StandartId equals standart.StandartId
                             select new
                             {
                                 studentName = student.StudentName,
                                 standartName = standart.StandartName
                             };
            foreach (var item in innerJoin2)
            {
                Console.WriteLine($"Query=> Student Name:{item.studentName}, Standart Name:{item.standartName}");
            }
            #endregion
        }
    }


}