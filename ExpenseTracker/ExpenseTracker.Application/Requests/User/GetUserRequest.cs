namespace ExpenseTracker.Application.Requests.User;

public sealed record GetUserRequest(
    Guid Id,
    string UserName,
    string Email,
    string? PhoneNumber,
    string? Search)
    : Common.UserRequestId(Id);