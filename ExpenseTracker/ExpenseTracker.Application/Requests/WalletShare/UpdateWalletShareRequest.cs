using ExpenseTracker.Domain.Enums;

namespace ExpenseTracker.Application.Requests.WalletShare;

internal sealed record UpdateWalletShareRequest(
    Guid UserId,
    int WalletId,
    IEnumerable<UserItem> UsersToShare)
    : CreateWalletShareRequest(
        UserId,
        WalletId,
        UsersToShare);
