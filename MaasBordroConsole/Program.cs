
using MaasBordroLib;
using System.Globalization;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace EF
{
    class Program
    {
        static string ad;
        static string soyad;
        static string unvan;
        static StreamReader fileReader;
        static string dosyaYolu = "C:\\Users\\AttilA\\Desktop\\Personeller\\Personeller.txt";
        static string mudurDosyaYolu = "C:\\Users\\AttilA\\Desktop\\Personeller\\Müdür";
        static string memurDosyaYolu = "C:\\Users\\AttilA\\Desktop\\Personeller\\Memur";
        static List<BasePersonel> personelList = new List<BasePersonel>();
        public static void Main(string[] args)
        {
            PersonelGiris();
            PersonelleriDosyayaYazdir();
            Sorgular();
        }

        public static void PersonelGiris()
        {
            int idSayac = 1;

            using (fileReader = new StreamReader(dosyaYolu))
            {
                while (!fileReader.EndOfStream) //dosyanın sonuna gelmediğim sürece satır satır okuma yapıcam
                {
                    PersonelOku(ref ad, ref soyad, ref unvan);

                    Console.WriteLine("Adı: " + ad);
                    Console.WriteLine("Soyadı: " + soyad);
                    Console.WriteLine("Ünvan: " + unvan);

                    //Console.Write("Id: ");
                    //string id = Console.ReadLine();

                    Console.Write("Saatlik Ücret: ");
                    double hourlyWage = double.Parse(Console.ReadLine());

                    Console.Write("Çalışma Saati: ");
                    double workingHour = double.Parse(Console.ReadLine());

                    if (unvan.ToLower() == "memur")
                    {
                        personelList.Add(new Memur(idSayac.ToString(), ad, soyad, hourlyWage, workingHour, unvan));
                        idSayac++;
                    }
                    else
                    {
                        Console.Write("Bonus: ");
                        double bonus = double.Parse(Console.ReadLine());
                        personelList.Add(new Mudur(idSayac.ToString(), ad, soyad, hourlyWage, workingHour, unvan, bonus));
                        idSayac++;
                    }
                    Console.WriteLine("*********************************");
                }
            }
        }

        public static void PersonelleriDosyayaYazdir()
        {
            foreach (BasePersonel personel in personelList)
            {
                if (personel.Unvan.ToLower() == "memur")
                {
                    string year = DateTime.Now.Year.ToString();
                    string month = DateTime.Now.ToString("MMMM", new CultureInfo("tr-TR"));
                    string dosyaAdı = $"{year}-{month}";

                    string dosyaYolu = Path.Combine(memurDosyaYolu, dosyaAdı);
                    //ay değiştiğinde faklı klasör oluşacak değişmezse aynı klasörün içine yazıcaz
                    if (!Directory.Exists(dosyaYolu))
                    {
                        Directory.CreateDirectory(dosyaYolu);
                    }

                    string adSoyad = $"{personel.PersonelAd} {personel.PersonelSoyad}";

                    string txtYol = Path.Combine(dosyaYolu, adSoyad + ".txt");

                    using (StreamWriter writer = new StreamWriter(txtYol))
                    {
                        personel.MaasHesapla();
                        writer.WriteLine(personel.ToString() + "\n");
                    }
                }
                else
                {
                    string year = DateTime.Now.Year.ToString();
                    string month = DateTime.Now.ToString("MMMM", new CultureInfo("tr-TR"));
                    string dosyaAdı = $"{year}-{month}";

                    string dosyaYolu = Path.Combine(mudurDosyaYolu, dosyaAdı);
                    //ay değiştiğinde faklı klasör oluşacak değişmezse aynı klasörün içine yazıcaz
                    if (!Directory.Exists(dosyaYolu))
                    {
                        Directory.CreateDirectory(dosyaYolu);
                    }

                    string adSoyad = $"{personel.PersonelAd} {personel.PersonelSoyad}";

                    string txtYol = Path.Combine(dosyaYolu, adSoyad + ".txt");

                    using (StreamWriter writer = new StreamWriter(txtYol))
                    {
                        personel.MaasHesapla();
                        writer.WriteLine(personel.ToString() + "\n");
                    }
                }
            }
        }

        public static void PersonelOku(ref string ad, ref string soyad, ref string unvan)
        {
            string satir = fileReader.ReadLine();
            if (satir != null)
            {
                string[] personel = satir.Split('-');
                if (personel.Length == 2)
                {
                    string adSoyad = personel[0].Trim();
                    unvan = personel[1].Trim();

                    string[] isimSoyisim = adSoyad.Split(' ');
                    if (isimSoyisim.Length == 2)
                    {
                        ad = isimSoyisim[0];
                        soyad = isimSoyisim[1];
                    }
                }
            }
        }

        public static void Sorgular()
        {
            IQueryable<BasePersonel> personels = personelList.AsQueryable();
            var maasBilgi = personels
                .Where(personel => personel.ToplamMaas > 100000);
            Console.WriteLine("Maaşı 100.00 den fazla olanlar");
            foreach (var item in maasBilgi)
            {
                Console.WriteLine($"Ad:{item.PersonelAd} Soyad:{item.PersonelSoyad} Maaş:{item.ToplamMaas}");
            }

            Console.WriteLine("***************************************************");

            var maasGetir = personels.Where(personel => personel.PersonelAd == "Fatih");
            Console.WriteLine("Fatihin Maaşını Getir");
            foreach (var item in maasGetir)
            {
                Console.WriteLine($"{item.PersonelAd} {item.PersonelSoyad} {item.ToplamMaas}");
            }

            Console.WriteLine("***************************************************");

            var grupla = personels
                .GroupBy(personel => personel.Unvan)
                .Select(grup => new
                {
                    Unvan = grup.Key,
                    Personeller = grup.ToList()
                });

            foreach (var item in grupla)
            {
                Console.WriteLine($"Ünvan:{item.Unvan}");
                foreach (var personel in item.Personeller)
                {
                    Console.WriteLine($"ID: {personel.PersonelId}, Ad: {personel.PersonelAd}, Soyad: {personel.PersonelSoyad}" +
                        $" Maaş: {personel.ToplamMaas}");
                }
            }
        }
    }
}



