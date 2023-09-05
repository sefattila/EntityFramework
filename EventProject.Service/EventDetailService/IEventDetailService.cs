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
        void Create(Customer entity);
        void Update(Customer entity);
        void Delete(Customer entity);
        bool Any(Expression<Func<Customer, bool>> expression);
        Customer GetDefault(Expression<Func<Customer, bool>> expression);
        Customer GetDefaultById(int id);
        IList<Customer> GetDefaults(Expression<Func<Customer, bool>> expression);
    }
}
