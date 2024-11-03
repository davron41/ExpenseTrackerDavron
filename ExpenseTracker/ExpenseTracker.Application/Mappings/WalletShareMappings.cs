using ExpenseTracker.Application.ViewModels.WalletShare;
using ExpenseTracker.Domain.Entities;

namespace ExpenseTracker.Application.Mappings;

public static class WalletShareMappings
{
    public static WalletShareViewModel ToViewModel(this WalletShare walletShare)
    {
        return new WalletShareViewModel
        {
            Id = walletShare.Id,
            Date = walletShare.Date,
            WalletName = walletShare.Wallet.Name,
            OwnerId = walletShare.Wallet.OwnerId,
            OwnerName = walletShare.Wallet.Owner.UserName!,
            WalletAccessType = walletShare.AccessType
        };
    }
}
