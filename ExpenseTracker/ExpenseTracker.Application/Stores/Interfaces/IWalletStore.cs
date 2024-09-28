using ExpenseTracker.Application.Requests.Common;
using ExpenseTracker.Application.Requests.Wallet;
using ExpenseTracker.Application.ViewModels.Wallet;

namespace ExpenseTracker.Application.Stores.Interfaces;

public interface IWalletStore
{
    WalletViewModel Create(CreateWalletRequest request);
    WalletViewModel CreateDefault(Guid userId);
    List<WalletViewModel> GetAll(UserRequest request);
}
