using EventProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EventProject.Service.CategoryService
{
    public interface ICategoryService
    {
        void Create(Category entity);
        void Update(Category entity);
        void Delete(Category entity);
        bool Any(Expression<Func<Category, bool>> expression);
        Category GetDefault(Expression<Func<Category, bool>> expression);
        Category GetDefaultById(int id);
        IList<Category> GetDefaults(Expression<Func<Category, bool>> expression);
        //...

        int GetEventCountByCategory(int categoryId);
    }
}
