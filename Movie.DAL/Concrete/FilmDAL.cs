using Microsoft.EntityFrameworkCore;
using Movie.DAL.Interfaces;
using Movie.DATA.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.DAL.Concrete
{
    public class FilmDAL : BaseDAL<Film>, IFilmDAL
    {
        private DbSet<Film> _table;
        //private DbSet<FilmCategory> _filmCategories;
        public FilmDAL(DbSet<Film> table, DbContext context) : base(table, context)
        {
            _table = table;
            //_filmCategories =context.Set<FilmCategory>();
        }

        public List<Film> GetFilms()
        {
            //var result = _table.Join(_filmCategories,
            //    film => film.CategoryId,
            //    category => category.Id,
            //    (film, category) => new
            //    {
            //        Id = film.Id,
            //        Name = film.FilmName,
            //        Duration = film.FilmDuration,
            //        KategoriAdi = category.CategoryName
            //    }
            //    );

            //return (List<Film>)result;

            return _table.ToList();
        }
    }
}
