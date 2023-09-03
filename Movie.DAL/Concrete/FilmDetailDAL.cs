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
    public class FilmDetailDAL : BaseDAL<FilmDetail>, IFilmDetailDAL
    {
        private DbSet<FilmDetail> _table;
        public FilmDetailDAL(DbSet<FilmDetail> table, DbContext context) : base(table, context)
        {
            _table = table; 
        }

        public List<FilmDetail> Get()
        {
            return _table.ToList();
        }
    }
}
