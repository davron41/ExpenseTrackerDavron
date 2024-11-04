using ExpenseTracker.Domain.Enums;

namespace ExpenseTracker.Application.ViewModels.WalletShare;

public class WalletShareViewModel
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public required string WalletName { get; set; }
    public Guid OwnerId { get; set; }
    public required string OwnerName { get; set; }
    public WalletAccessType WalletAccessType { get; set; }
}
