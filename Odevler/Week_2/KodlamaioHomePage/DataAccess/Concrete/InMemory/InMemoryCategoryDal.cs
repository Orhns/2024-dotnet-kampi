using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCategoryDal : ICategoryDal
    {
        private List<Category> _categories;
        public InMemoryCategoryDal()
        {
            _categories = new List<Category>();
            _categories.Add(new Category { CategoryId = 1, CategoryName = "Programlama" });
            _categories.Add(new Category { CategoryId = 2, CategoryName = "Diksyon" });
            _categories.Add(new Category { CategoryId = 3, CategoryName = "Zaman yönetimi" });
        }
        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Delete(Category category)
        {
            Category categoryToDelete = _categories.SingleOrDefault(c => c.CategoryId == category.CategoryId);
            _categories.Remove(categoryToDelete);
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public Category GetCategory(int id)
        {
            return (Category)_categories[id];
        }

        public void Update(Category category)
        {
            Category categoryToUpdate = _categories.SingleOrDefault(c => c.CategoryId == category.CategoryId);
            categoryToUpdate.CategoryName = category.CategoryName;
        }
    }
}
