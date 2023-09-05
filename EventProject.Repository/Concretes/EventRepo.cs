using EventProject.Core.Entities;
using EventProject.Repository.Contexts;
using EventProject.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventProject.Repository.Concretes
{
    public class EventRepo : BaseRepo<Event>, IEventRepo
    {
        private readonly AppDbContext _context;
        public EventRepo(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public IList<Event> GetEventsByDate(DateTime startDate, DateTime endDate)
        {
            return _context.Events
                .Where(x => (x.EventStartDate >= startDate && x.EventStartDate <= endDate) ||
                (x.EventDinishDate <= endDate && x.EventDinishDate >= startDate)).ToList();
        }

        public IList<Event> GetEventsLocation(string location)
        {
            return _context.Events.Where(x => x.EventLocation.Contains(location.ToLower())).ToList();
        }

        public IList<Event> GetEventsOrderByPriceASC()
        {
            return _context.Events.OrderBy(x => x.EventPrice).ToList();
        }

        public IList<Event> GetEventsOrderByPriceDESC()
        {
            return _context.Events.OrderByDescending(x => x.EventPrice).ToList();
        }
    }
}
