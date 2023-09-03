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
    public class FilmActorDAL : BaseDAL<FilmActor>, IFilmActor
    {
        private DbSet<FilmActor> _table;
        public FilmActorDAL(DbSet<FilmActor> table, DbContext context) : base(table, context)
        {
            _table = table;
        }

        public List<FilmActor> Get()
        {
            return _table.ToList();
        }
    }
}
