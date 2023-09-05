using EventProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EventProject.Service.EventService
{
    public interface IEventService
    {
        void Create(Event entity);
        void Update(Event entity);
        void Delete(Event entity);
        bool Any(Expression<Func<Event, bool>> expression);
        Event GetDefault(Expression<Func<Event, bool>> expression);
        Event GetDefaultById(int id);
        IList<Event> GetDefaults(Expression<Func<Event, bool>> expression);
        //...

        IList<Event> GetEventsOrderByPriceASC();
        IList<Event> GetEventsOrderByPriceDESC();
        IList<Event> GetEventsByDate(DateTime startDate, DateTime endDate);
        IList<Event> GetEventsLocation(string location);

    }
}
