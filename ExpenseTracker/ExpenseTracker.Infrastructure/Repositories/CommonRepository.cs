using ExpenseTracker.Domain.Interfaces;
using ExpenseTracker.Infrastructure.Persistence;

namespace ExpenseTracker.Infrastructure.Repositories;

internal sealed class CommonRepository : ICommonRepository
{
    private readonly ExpenseTrackerDbContext _context;

    private readonly ITransferRepository _transfers;
    public ITransferRepository Transfers => _transfers;

    private readonly ICategoryRepository _categories;
    public ICategoryRepository Categories => _categories;

    private readonly IImageFileRepository _imageFiles;
    public IImageFileRepository ImageFiles => _imageFiles;

    private readonly IWalletRepository _wallets;
    public IWalletRepository Wallets => _wallets;

    private readonly IWalletShareRepository _walletShares;
    public IWalletShareRepository WalletShares => _walletShares;

    private readonly IUserRepository _users;
    public IUserRepository Users => _users;

    public CommonRepository(ExpenseTrackerDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));

        _categories = new CategoryRepository(context);
        _transfers = new TransferRepository(context);
        _imageFiles = new ImageFileRepository(context);
        _wallets = new WalletRepository(context);
        _walletShares = new WalletShareRepository(context);
        _users = new UserRepository(context);
    }

    public int SaveChanges() => _context.SaveChanges();
}
