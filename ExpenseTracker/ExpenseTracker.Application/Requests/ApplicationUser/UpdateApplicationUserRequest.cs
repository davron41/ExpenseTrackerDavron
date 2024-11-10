using ExpenseTracker.Application.Requests.Common;

namespace ExpenseTracker.Application.Requests.ApplicationUser;

public sealed record UpdateApplicationUserRequest(
    Guid Id,
    string UserName,
    string Email,
    string? PhoneNumber,
    string Password)
    : UserRequest(Id);