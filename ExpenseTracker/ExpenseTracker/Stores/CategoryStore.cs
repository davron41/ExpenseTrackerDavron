using ExpenseTracker.Domain.Entities;
using ExpenseTracker.Domain.Interfaces;

namespace ExpenseTracker.Stores
{
    public interface ICategoryStore
    {
        void Add(Category category);
    }
    public class CategoryStore : ICategoryStore
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryStore(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public void Add(Category category)
        {
            _categoryRepository.Create(category);
        }
    }
    public class NewCategoryStore : ICategoryStore
    {
        public void Add(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
