﻿using EventProject.Core.Entities;
using EventProject.Repository.Contexts;
using EventProject.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EventProject.Repository.Concretes
{
    public class EventDetailRepo : IEventDetailRepo
    {
        private readonly AppDbContext _context;

        public EventDetailRepo(AppDbContext context)
        {
            this._context = context;
        }

        public bool Any(Expression<Func<EventDetail, bool>> expression)
        {
            return _context.EventDetails.Any(expression);
        }

        public void Create(EventDetail entity)
        {
            _context.EventDetails.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(EventDetail entity)
        {
            _context.EventDetails.Remove(entity);
            _context.SaveChanges();
        }

        public EventDetail GetDefault(Expression<Func<EventDetail, bool>> expression)
        {
            return _context.EventDetails.FirstOrDefault(expression);
        }

        public EventDetail GetDefaultById(int id)
        {
            return _context.EventDetails.Find(id);
        }

        public IList<EventDetail> GetDefaults(Expression<Func<EventDetail, bool>> expression)
        {
            return _context.EventDetails.Where(expression).ToList();
        }

        public void Update(EventDetail entity)
        {
            _context.SaveChanges();
        }
    }
}
