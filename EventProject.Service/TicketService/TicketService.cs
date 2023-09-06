using EventProject.Core.Entities;
using EventProject.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EventProject.Service.TicketService
{
    public class TicketService : ITicketService
    {
        private readonly ITicketRepo _repo;

        public TicketService(ITicketRepo repo)
        {
            this._repo = repo;
        }

        public bool Any(Expression<Func<Ticket, bool>> expression)
        {
            return _repo.Any(expression);
        }

        public void Create(Ticket entity)
        {
            if(entity.Customer!= null)
            {
                if (entity.Event != null)
                {
                    if (entity.Customer.CustomerAge >= entity.Event.EventAgeControl)
                    {
                        _repo.Create(entity);
                    }
                    else throw new Exception("Yaş yetmiir");
                }
                else throw new Exception("Event Seçiniz...");
            }
            else throw new Exception("Müşteri Seçiniz");
        }

        public void Delete(Ticket entity)
        {
            _repo.Delete(entity);
        }

        public int GetAttendCount(int eventId)
        {
            return _repo.GetAttendCount(eventId);
        }

        public IList<Customer> GetAttends(int eventId)
        {
            return _repo.GetAttends(eventId);
        }

        public int GetCustomerOfEventCount(int customerId)
        {
            return _repo.GetCustomerOfEventCount(customerId);
        }

        public IList<Event> GetCustomerOfEvents(int customerId)
        {
            return _repo.GetCustomerOfEvents(customerId);
        }

        public Ticket GetDefault(Expression<Func<Ticket, bool>> expression)
        {
            return _repo.GetDefault(expression);
        }

        public Ticket GetDefaultById(int id)
        {
            return _repo.GetDefaultById(id);
        }

        public IList<Ticket> GetDefaults(Expression<Func<Ticket, bool>> expression)
        {
            return _repo.GetDefaults(expression);
        }

        public void Update(Ticket entity)
        {
            _repo.Update(entity);
        }
    }
}
