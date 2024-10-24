using ExpenseTracker.Application.Requests.Common;

namespace ExpenseTracker.Application.Requests.Transfer;

public record CreateTransferRequest(
    Guid UserId,
    int CategoryId,
    int WalletId,
    string? Notes,
    decimal Amount,
    DateTime Date)
    : UserRequestId(UserId: UserId);
