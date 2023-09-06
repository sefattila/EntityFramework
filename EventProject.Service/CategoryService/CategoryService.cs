using EventProject.Core.Entities;
using EventProject.Core.Enums;
using EventProject.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EventProject.Service.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepo _repo;

        public CategoryService(ICategoryRepo repo)
        {
            _repo = repo;
        }

        public bool Any(Expression<Func<Category, bool>> expression)
        {
            return _repo.Any(expression);
        }

        public void Create(Category entity)
        {
            if (!Any(x => x.CategoryName.ToLower() != entity.CategoryName.ToLower()))
            {
                _repo.Create(entity);
            }
            else throw new Exception("Aynı Kategori İsmi Mevcut");
        }

        public void Delete(Category entity)
        {
            if (GetDefaultById(entity.Id!) != null)
            {
                entity.DeleteDate = DateTime.Now;
                entity.Status = Status.Passive;
                _repo.Delete(entity);
            }
            else throw new Exception("Yok");
        }

        public Category GetDefault(Expression<Func<Category, bool>> expression)
        {
            return _repo.GetDefault(expression);
        }

        public Category GetDefaultById(int id)
        {
            return _repo.GetDefaultById(id);
        }

        public IList<Category> GetDefaults(Expression<Func<Category, bool>> expression)
        {
            return _repo.GetDefaults(expression).Where(c => c.Status != Status.Passive).ToList();
        }

        public int GetEventCountByCategory(int categoryId)
        {
            return _repo.GetEventCountByCategory(categoryId);
        }

        public void Update(Category entity)
        {
            entity.UpdateDate= DateTime.Now;
            entity.Status = Status.Modified;
            _repo.Update(entity);
        }
    }
}
