﻿using EventProject.Repository.Contexts;
using EventProject.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EventProject.Repository.Concretes
{
    public class BaseRepo<T> : IBaseRepo<T> where T : class
    {
        private readonly AppDbContext _context;
        protected DbSet<T> _table;

        public BaseRepo(AppDbContext context)
        {
            _context = context;
            _table = context.Set<T>();
        }

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
            _context.SaveChanges();
        }

        public T GetDefault(Expression<Func<T, bool>> expression)
        {
            return _table.FirstOrDefault(expression);
        }

        public T GetDefaultById(int id)
        {
            return _table.Find(id);
        }

        public IList<T> GetDefaults(Expression<Func<T, bool>> expression)
        {
            return _table.Where(expression).ToList();
        }

        public void Update(T entity)
        {
            _context.Entry<T>(entity).State= EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
