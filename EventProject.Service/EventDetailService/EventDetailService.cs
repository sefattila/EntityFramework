using EventProject.Core.Entities;
using EventProject.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EventProject.Service.EventDetailService
{
    public class EventDetailService : IEventDetailService
    {
        private readonly IEventDetailRepo _repo;

        public EventDetailService(IEventDetailRepo repo)
        {
            this._repo = repo;
        }

        public bool Any(Expression<Func<EventDetail, bool>> expression)
        {
            return _repo.Any(expression);
        }

        public void Create(EventDetail entity)
        {
            if (entity.EventDetailId > 0 && Any(x => x.EventDetailId != entity.EventDetailId))
            {
                _repo.Create(entity);
            }
            else throw new Exception("Böyle Bir Id Var");
        }

        public void Delete(EventDetail entity)
        {
            _repo.Delete(entity);
        }

        public EventDetail GetDefault(Expression<Func<EventDetail, bool>> expression)
        {
            return _repo.GetDefault(expression);
        }

        public EventDetail GetDefaultById(int id)
        {
            return _repo.GetDefaultById(id);
        }

        public IList<EventDetail> GetDefaults(Expression<Func<EventDetail, bool>> expression)
        {
            return _repo.GetDefaults(expression);
        }

        public void Update(EventDetail entity)
        {
            _repo.Update(entity);
        }
    }
}
