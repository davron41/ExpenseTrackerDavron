using ExpenseTracker.Application.Requests.Category;
using ExpenseTracker.Application.ViewModels.Category;

namespace ExpenseTracker.Stores.Interfaces;

public interface ICategoryStore
{
    List<CategoryViewModel> GetAll(GetCategoriesRequest request);
    CategoryViewModel GetById(int id);
    CategoryViewModel Create(CreateCategoryRequest request);
    void Update(UpdateCategoryViewModel category);
    void Delete(int id);
}
