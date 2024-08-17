using ExpenseTracker.Domain.Enums;

namespace ExpenseTracker.ViewModels.Category;

public class CreateCategoryViewModel
{
    public string Name { get; set; }
    public string? Description { get; set; }
    public CategoryType Type { get; set; }
}
