using ExpenseTracker.Application.Requests.Common;

namespace ExpenseTracker.Application.Requests.Wallet;

public record CreateWalletRequest(
    Guid UserId,
    string Name, 
    string? Description, 
    decimal Balance) 
    : UserRequest(UserId: UserId);
