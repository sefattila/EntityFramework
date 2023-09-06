using EventProject.Core.Entities;
using EventProject.Core.Enums;
using EventProject.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EventProject.Service.EventService
{
    public class EventService : IEventService
    {
        private readonly IEventRepo _repo;

        public EventService(IEventRepo repo)
        {
            this._repo = repo;
        }

        public bool Any(Expression<Func<Event, bool>> expression)
        {
            return _repo.Any(expression);
        }

        public void Create(Event entity)
        {
            _repo.Create(entity);
        }

        public void Delete(Event entity)
        {
            entity.DeleteDate = DateTime.Now;
            entity.Status = Status.Passive;
            _repo.Delete(entity);
        }

        public Event GetDefault(Expression<Func<Event, bool>> expression)
        {
            return _repo.GetDefault(expression);
        }

        public Event GetDefaultById(int id)
        {
            return _repo.GetDefaultById(id);
        }

        public IList<Event> GetDefaults(Expression<Func<Event, bool>> expression)
        {
            return _repo.GetDefaults(expression);
        }

        public IList<Event> GetEventsByDate(DateTime startDate, DateTime endDate)
        {
            return _repo.GetEventsByDate(startDate, endDate);
        }

        public IList<Event> GetEventsLocation(string location)
        {
            return _repo.GetEventsLocation(location);
        }

        public IList<Event> GetEventsOrderByPriceASC()
        {
            return _repo.GetEventsOrderByPriceASC();
        }

        public IList<Event> GetEventsOrderByPriceDESC()
        {
            return _repo.GetEventsOrderByPriceDESC();
        }

        public void Update(Event entity)
        {
            entity.UpdateDate= DateTime.Now;
            entity.Status = Status.Modified;
            _repo.Update(entity);
        }
    }
}
