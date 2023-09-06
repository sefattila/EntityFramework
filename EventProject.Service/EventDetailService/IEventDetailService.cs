using EventProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EventProject.Service.EventDetailService
{
    public interface IEventDetailService
    {
        void Create(EventDetail entity);
        void Update(EventDetail entity);
        void Delete(EventDetail entity);
        bool Any(Expression<Func<EventDetail, bool>> expression);
        EventDetail GetDefault(Expression<Func<EventDetail, bool>> expression);
        EventDetail GetDefaultById(int id);
        IList<EventDetail> GetDefaults(Expression<Func<EventDetail, bool>> expression);
    }
}
