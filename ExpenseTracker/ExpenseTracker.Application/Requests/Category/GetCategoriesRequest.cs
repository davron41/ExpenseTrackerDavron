using ExpenseTracker.Application.Requests.Common;

namespace ExpenseTracker.Application.Requests.Category;

public record GetCategoriesRequest(
    Guid UserId,
    string? Search)
    : UserRequest(UserId: UserId);
