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
    public class FilmCategoryDAL : BaseDAL<FilmCategory>, IFilmCategory
    {
        private DbSet<FilmCategory> _table;
        public FilmCategoryDAL(DbSet<FilmCategory> table, DbContext context) : base(table, context)
        {
            _table = table;
        }

        public List<FilmCategory> Get()
        {
            return _table.ToList();
        }
    }
}
