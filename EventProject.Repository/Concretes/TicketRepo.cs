using EventProject.Core.Entities;
using EventProject.Repository.Contexts;
using EventProject.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventProject.Repository.Concretes
{
    public class TicketRepo : BaseRepo<Ticket>, ITicketRepo
    {
        private readonly AppDbContext _context;
        public TicketRepo(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public int GetAttendCount(int eventId)
        {
            return _context.Tickets.Count(x => x.EventId == eventId);
        }

        public IList<Customer> GetAttends(int eventId)
        {
            //return _context.Tickets
            //    .Where(x => x.EventId == eventId)
            //    .Select(x => new Customer
            //    {
            //        Id = x.Customer.Id,
            //        CustomerName=x.Customer.CustomerName,
            //        CustomerAge=x.Customer.CustomerAge,
            //        CustomerPhone=x.Customer.CustomerPhone
            //    }).ToList();

            //return _context.Tickets.Where(x => x.EventId == eventId)
            //    .Join(_context.Customers,
            //    ticket => ticket.CustomerId,
            //    customer => customer.Id,
            //    (ticket, customer) => new Customer
            //    {
            //        Id = customer.Id,
            //        CustomerName = customer.CustomerName,
            //        CustomerAge = customer.CustomerAge,
            //        CustomerPhone = customer.CustomerPhone
            //    }
            //    ).ToList();

            return _context.Customers.Include(x => x.Tickets)
                .Where(x => x.Tickets.Any(x => x.EventId.Equals(eventId))).ToList();
        }

        public int GetCustomerOfEventCount(int customerId)
        {
            return _context.Tickets.Count(x => x.CustomerId == customerId);
        }

        public IList<Event> GetCustomerOfEvents(int customerId)
        {
            return _context.Tickets
                .Join(_context.Events,
                t => t.EventId,
                e => e.Id,
                (t, e) => new Event
                {
                    Id = e.Id,
                    EventName = e.EventName,
                    EventPrice = e.EventPrice,
                    EventAttends = e.EventAttends,
                    EventDetail = e.EventDetail,
                    EventAgeControl = e.EventAgeControl,
                    EventLocation = e.EventLocation,
                    EventDinishDate = e.EventDinishDate,
                    EventStartDate = e.EventStartDate,
                }
                ).ToList();

        }
    }
}
