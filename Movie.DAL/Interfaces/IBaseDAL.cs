using Microsoft.EntityFrameworkCore.Query;
using Movie.DATA.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Movie.DAL.Interfaces
{
    public interface IBaseDAL<T> where T : BaseFilm
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        bool Any(Expression<Func<T, bool>> expression);
        T GetDefault(Expression<Func<T, bool>> expression); //firstordefault - singleordefault
        List<T> GetDefaults(Expression<Func<T, bool>> expression); //tüm filmleri getir vs
        List<TResult> GetFilteredList<TResult>(Expression<Func<T, TResult>> select,
                                               Expression<Func<T, bool>> where,
                                               Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                               Func<IQueryable<T>, IIncludableQueryable<T, object>> join = null); //listelemek istediğim satırları

    }
}
