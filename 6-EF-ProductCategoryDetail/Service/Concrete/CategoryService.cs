using _6_EF_ProductCategoryDetail.Context;
using _6_EF_ProductCategoryDetail.Entities;
using _6_EF_ProductCategoryDetail.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _6_EF_ProductCategoryDetail.Service.Concrete
{
    public class CategoryService : ICategory
    {
        private readonly AppDbContext _context;

        public CategoryService(AppDbContext context)
        {
            this._context = context;
        }
        public void Add(Category entity)
        {
            _context.Categories.Add(entity); //context.Add(entity);
            _context.SaveChanges();

            //using (var context = new AppDbContext())
            //{
            //    context.Categories.Add(entity); //context.Add(entity);
            //    context.SaveChanges();
            //}
        }

        public void Delete(Category entity)
        {
            _context.Categories.Remove(entity);
            _context.SaveChanges();
            //using (var context = new AppDbContext())
            //{
            //    context.Categories.Remove(entity);
            //    context.SaveChanges();
            //}
        }

        public IList<Category> GetByDefaults(Expression<Func<Category, bool>> expression)
        {
            return _context.Categories.Where(expression).ToList();

            //using (var context = new AppDbContext())
            //{
            //    return context.Categories.Where(expression).ToList();
            //}
        }

        public IList<Category> GetCategory()
        {
            return _context.Categories.ToList();
            //using (var context = new AppDbContext())
            //{
            //    var getCategory = context.Categories.ToList();
            //    return getCategory;
            //}
        }

        public bool GetCategoryAny(int id)
        {
            return _context.Categories.Any(a => a.CategoryId == id);
            //using (var context = new AppDbContext())
            //{
            //    return context.Categories.Any(a => a.CategoryId == id);
            //}
        }

        public Category GetCategoryById(int id)
        {
            return _context.Categories.Find(id);

            //using (var context = new AppDbContext())
            //{
            //    var getCategory = context.Categories.Find(id);
            //    return getCategory;
            //}
        }

        public void Update(Category entity)
        {
            _context.Categories.Update(entity);
            _context.SaveChanges();

            //using (var context = new AppDbContext())
            //{
            //    context.Categories.Add(entity);
            //    entity.Name = "Sebze";
            //    context.SaveChanges();
            //}
        }
    }
}
