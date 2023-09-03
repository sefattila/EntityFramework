using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Movie.DAL.Interfaces;
using Movie.DATA.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Movie.DAL.Concrete
{
    public class BaseDAL<T> : IBaseDAL<T> where T : BaseFilm
    {//eklemeleri yapıcam
        private DbSet<T> _table;
        private DbContext _context;

        public BaseDAL(DbSet<T> table,DbContext context)
        {
            _context = context;
            _table = table;
        }

        //Verdiğim değeri karşılıyor mu?
        public bool Any(Expression<Func<T, bool>> expression)
        {
            return _table.Any(expression);
        }

        public void Create(T entity)
        {
            _table.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _table.Remove(entity);
            _context.SaveChanges();
        }

        //public List<T> Get()
        //{
        //    return _table.ToList();
        //}

        public T GetDefault(Expression<Func<T, bool>> expression)
        {
            return _table.FirstOrDefault(expression);
        }

        public List<T> GetDefaults(Expression<Func<T, bool>> expression)
        {
            return _table.Where(expression).ToList();
        }

        public List<TResult> GetFilteredList<TResult>(Expression<Func<T, TResult>> select, 
            Expression<Func<T, bool>> where, 
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, 
            Func<IQueryable<T>, IIncludableQueryable<T, object>> join = null)
        {
            IQueryable<T> query = _table;
            if (join != null)
            {
                query = join(_table);
            }
            if(where!= null)
            {
                query=query.Where(where);
            }
            if(orderBy!= null)
            {
                return orderBy(query).Select(select).ToList();
            }
            else
            {
                return query.Select(select).ToList();
            }
        }

        public void Update(T entity)
        {
            _table.Update(entity);
            _context.SaveChanges();
        }
    }
}
