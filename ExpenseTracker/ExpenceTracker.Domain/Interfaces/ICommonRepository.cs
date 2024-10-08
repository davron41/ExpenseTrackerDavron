namespace ExpenseTracker.Domain.Interfaces;

public interface ICommonRepository
{
    ITransferRepository Transfers { get; }
    ICategoryRepository Categories { get; }
    IImageFileRepository ImageFiles { get; }
    IWalletRepository Wallets { get; }
    IWalletShareRepository WalletShares { get; }
    IUserRepository Users { get; }

    public int SaveChanges();
}
