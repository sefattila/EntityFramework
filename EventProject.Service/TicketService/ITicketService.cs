using EventProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EventProject.Service.TicketService
{
    public interface ITicketService
    {
        void Create(Ticket entity);
        void Update(Ticket entity);
        void Delete(Ticket entity);
        bool Any(Expression<Func<Ticket, bool>> expression);
        Ticket GetDefault(Expression<Func<Ticket, bool>> expression);
        Ticket GetDefaultById(int id);
        IList<Ticket> GetDefaults(Expression<Func<Ticket, bool>> expression);
        //..

        //eventteki kişi sayısı
        int GetAttendCount(int eventId);
        //eventteki kişiler
        IList<Customer> GetAttends(int eventId);
        //müşterinin event sayısı
        int GetCustomerOfEventCount(int customerId);

        IList<Event> GetCustomerOfEvents(int customerId);
    }
}
