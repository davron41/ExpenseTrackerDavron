using ExpenseTracker.Application.Requests.Common;

namespace ExpenseTracker.Application.Requests.Transfer;

public sealed record GetTransfersRequest(
    Guid UserId,
    int? CategoryId,
    int? WalletId,
    string? Search,
    decimal MaxAmount,
    decimal? MinAmount)
    : UserRequestId(UserId: UserId);
