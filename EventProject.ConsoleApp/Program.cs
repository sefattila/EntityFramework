using EventProject.Core.Entities;
using EventProject.Core.Enums;
using EventProject.Repository.Concretes;
using EventProject.Repository.Contexts;
using EventProject.Repository.Interfaces;
using EventProject.Service.CategoryService;
using EventProject.Service.CustomerService;
using EventProject.Service.EventDetailService;
using EventProject.Service.EventService;
using EventProject.Service.TicketService;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System.Xml.Serialization;

namespace EventProject.ConsoleApp
{
    internal class Program
    {
        private static AppDbContext _appDbContext;

        private static ICategoryRepo _categoryRepo;
        private static ICategoryService _categoryService;

        private static IEventRepo _eventRepo;
        private static IEventService _eventService;

        private static IEventDetailRepo _eventDetailRepo;
        private static IEventDetailService _eventDetailService;

        private static ICustomerRepo _customerRepo;
        private static ICustomerService _customerService;

        private static ITicketRepo _ticketRepo;
        private static ITicketService _ticketService;
        static void Main(string[] args)
        {
            _appDbContext = new AppDbContext();

            _categoryRepo = new CategoryRepo(_appDbContext);
            _categoryService = new CategoryService(_categoryRepo);
            //CategoryAdd();
            //CategoryList();
            //CategoryUpdate();
            //CategoryList();

            _eventRepo = new EventRepo(_appDbContext);
            _eventService = new EventService(_eventRepo);
            //EventAdd();
            EventGets();

            _eventDetailRepo = new EventDetailRepo(_appDbContext);
            _eventDetailService = new EventDetailService(_eventDetailRepo);

            //EventDetailAdd();

            _customerRepo = new CustomerRepo(_appDbContext);
            _customerService = new CustomerService(_customerRepo);
            //CustomerAdd();
            CustomerList();

            _ticketRepo=new TicketRepo(_appDbContext);  
            _ticketService=new TicketService(_ticketRepo);

            //BiletAl();

            KatilimciSayisi();
            KatilimciBilgileri();
            MusteriKonserBilgileri();

            Console.WriteLine("Niceeeeee!!!");
        }
        #region Category
        public static void CategoryAdd()
        {
            _categoryService.Create(new Category() { CategoryName = "Açık Hava Konseri" });
        }
        public static void CategoryList()
        {
            var category = _categoryService.GetDefaults(x => x.Status != Status.Passive);
            foreach (var item in category)
            {
                Console.WriteLine($"Kategori Id:{item.Id} Kategori Adı:{item.CategoryName}");
            }
        }
        public static void CategoryUpdate()
        {
            Console.Write("Güncellemek İçin Id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            var category = _categoryService.GetDefaultById(id);

            Console.Write($"Kategori Adı:{category.CategoryName}\nYeni Ad:");
            category.CategoryName = Console.ReadLine();

            _categoryService.Update(category);
        }
        #endregion

        #region Event

        public static void EventAdd()
        {
            CategoryList();
            Console.Write("Event Eklemek istediğiniz category id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            var eventt = new Event()
            {
                CategoryId = id,
                EventName = "MFO",
                EventAgeControl = 24,
                EventAttends = 50,
                EventStartDate = DateTime.Now.AddDays(10),
                EventDinishDate = DateTime.Now.AddDays(30),
                EventLocation = "Tosya",
                EventPrice = 100
            };

            _eventService.Create(eventt);
        }

        private static void EventGets()
        {
            var events = _eventService.GetDefaults(x => x.Status != Status.Passive);
            //var events=_eventService.GetEventsOrderByPriceDESC();
            //var events = _eventService.GetEventsLocation("tosya");
            foreach (var item in events)
            {
                Console.WriteLine($"{item.Id} {item.EventName} {item.EventPrice} {item.EventStartDate}" +
                    $"{item.EventDinishDate} {item.EventAttends} {item.EventAgeControl} {item.EventLocation}");
            }
        }


        #endregion

        #region EventDetail

        private static void EventDetailAdd()
        {
            var eventDetail = new EventDetail()
            {
                EventDetailId = 2,
                EventMail = "sefa@gmail.com",
                EventPhone = "555555555"
            };

            _eventDetailService.Create(eventDetail);
        }


        #endregion

        #region Customer
        public static void CustomerAdd()
        {
            var customer = new Customer()
            {
                CustomerName = "Fevzi",
                CustomerAge = 10,
                CustomerPhone = 555
            };

            _customerService.Create(customer);
        }

        public static void CustomerList()
        {
            var customers = _customerService.GetDefaults(x => x.Status != Status.Passive);
            foreach (var item in customers)
            {
                Console.WriteLine($"Id:{item.Id} Adı:{item.CustomerName} Yas:{item.CustomerAge}");
            }
        }

        #endregion

        #region Ticket

        public static void BiletAl()
        {
            Console.Write("Müşteri Id:");
            int customerId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Event Id:");
            int eventId = Convert.ToInt32(Console.ReadLine());

            var customer=_customerService.GetDefaultById(customerId);
            var event1=_eventService.GetDefaultById(eventId);

            var ticket = new Ticket() { Customer = customer, CustomerId = customerId, Event = event1, EventId = eventId };

            _ticketService.Create(ticket);
        }

        public static void KatilimciSayisi()
        {
            Console.WriteLine(_ticketService.GetAttendCount(2));
        }

        public static void KatilimciBilgileri()
        {
            var musteri=_ticketService.GetAttends(2);
            foreach (var item in musteri)
            {
                Console.WriteLine($"Adı:{item.CustomerName}");
            }
        }

        public static void MusteriKonserBilgileri()
        {
            var konser=_ticketService.GetCustomerOfEvents(2);
            foreach (var item in konser)
            {
                Console.WriteLine($"Konser Adı:{item.EventName}");
            }
        }

        #endregion
    }
}