using ExpenseTracker.Application.Requests.Common;

namespace ExpenseTracker.Application.Requests.Category;

public record CategoryRequest(
    Guid UserId,
    int CategoryId)
    : UserRequest(UserId: UserId);
