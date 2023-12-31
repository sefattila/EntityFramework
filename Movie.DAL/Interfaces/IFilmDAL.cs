﻿using Movie.DATA.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.DAL.Interfaces
{
    public interface IFilmDAL:IBaseDAL<Film>
    {
        List<Film> GetFilms();
    }
}
