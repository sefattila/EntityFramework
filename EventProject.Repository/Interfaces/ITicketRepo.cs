using EventProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventProject.Repository.Interfaces
{
    public interface ITicketRepo : IBaseRepo<Ticket>
    {
        //eventteki kişi sayısı
        int GetAttendCount(int eventId);
        //eventteki kişiler
        IList<Customer> GetAttends(int eventId);
        //müşterinin event sayısı
        int GetCustomerOfEventCount(int customerId);
        
        IList<Event> GetCustomerOfEvents(int customerId);
    }
}
