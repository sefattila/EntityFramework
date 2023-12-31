﻿using Microsoft.EntityFrameworkCore;
using Movie.DAL.Interfaces;
using Movie.DATA.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.DAL.Concrete
{
    public class ActorDAL : BaseDAL<Actor>, IActorDAL
    {
        private DbSet<Actor> _table;
        public ActorDAL(DbSet<Actor> table, DbContext context) : base(table, context)
        {
            _table = table;
        }

        public List<Actor> GetActors()
        {
            return _table.ToList();
        }
    }
}
