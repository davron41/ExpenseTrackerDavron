using ExpenseTracker.Application.Requests.Common;

namespace ExpenseTracker.Application.Requests.Category;

public sealed record CategoryRequest(
    Guid UserId,
    int Id)
    : UserRequestId(UserId: UserId);
