using ExpenseTracker.Application.Requests.Common;
using ExpenseTracker.Domain.Enums;

namespace ExpenseTracker.Application.Requests.WalletShare;

public record CreateWalletShareRequest(
    Guid UserId,
    int WalletId,
    IEnumerable<UserItem> UsersToShare)
    : UserRequest(UserId: UserId);

public class UserItem
{
    public int Id { get; set; }
    public string Text { get; set; }
}
