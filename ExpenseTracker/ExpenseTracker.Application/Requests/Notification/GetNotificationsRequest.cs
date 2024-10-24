using ExpenseTracker.Application.Requests.Common;

namespace ExpenseTracker.Application.Requests.Notification;

public sealed record GetNotificationsRequest(Guid UserId)
    : UserRequestId(UserId: UserId);
