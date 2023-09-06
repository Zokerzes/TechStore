using TechStore.Data;
using TechStore.Interfaces;
using TechStore.Models;

namespace TechStore.Repository
{
    public class CategoryRepositiry : ICategoryRepository
    {
        private readonly AppDbContext _context;
        public CategoryRepositiry(AppDbContext context) 
        {
            _context = context;
        }
        public bool CategoryExists(int id)
        {
            return _context.Categories.Any(c=> c.Id == id);   
        }

        public bool CreateCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCategory(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Category> GetCategories()
        {
            throw new NotImplementedException();
        }

        public Category GetCategory(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Product> GetProductsByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool UpdateCategory(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
