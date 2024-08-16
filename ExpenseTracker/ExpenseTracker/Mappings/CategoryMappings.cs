using ExpenseTracker.Domain.Entities;
using ExpenseTracker.ViewModels.Category;

namespace ExpenseTracker.Mappings;

public static class CategoryMappings
{
    public static CategoryViewModel ToViewModel(this Category category)
    {
        return new CategoryViewModel
        {
            Id = category.Id,
            Name = category.Name,
            Description = category.Description,
            CreatedAt = category.CreatedAt,
            UpdatedAt = category.UpdatedAt,
        };
    }

    public static UpdateCategoryViewModel ToViewModel(this CategoryViewModel category)
    {
        return new UpdateCategoryViewModel
        {
            Id = category.Id,
            Name = category.Name,
            Description = category.Description
        };
    }

    public static Category ToEntity(this CreateCategoryViewModel category)
    {
        return new Category
        {
            Name = category.Name,
            Description = category.Description,
        };
    }
        

    public static Category ToEntity(this UpdateCategoryViewModel category)
    {
        return new Category
        {
            Id = category.Id,
            Name = category.Name,
            Description = category.Description,
        };
    }
}
