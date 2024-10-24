using ExpenseTracker.Application.Requests.Common;
using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Application.Requests.Wallet;

public record CreateWalletRequest(
    Guid UserId,
    [Required(ErrorMessage = "Name is required")]
    string Name, 
    string? Description,
    [Required(ErrorMessage = "Balance entry is mandatory")]
    decimal Balance) 

    : UserRequest(UserId: UserId);
