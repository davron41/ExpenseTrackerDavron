using ExpenseTracker.Domain.Enums;

namespace ExpenseTracker.Application.Requests.Category;

public record UpdateCategoryRequest(
    Guid UserId,
    int CategoryId,
    string Name,
    string? Description,
    CategoryType Type)
    : CreateCategoryRequest(
        UserId: UserId,
        Name: Name,
        Description: Description,
        Type: Type);
