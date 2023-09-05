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
    public class EventDetailRepo : BaseRepo<EventDetail>, IEventDetailRepo
    {
        public EventDetailRepo(AppDbContext context) : base(context)
        {
        }
    }
}
