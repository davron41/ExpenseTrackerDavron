using ExpenseTracker.Domain.Interfaces;

namespace ExpenseTracker.Infrastructure.Repositories;

public class CommonRepository : ICommonRepository
{
    private readonly ExpenseTrackerDbContext _context;

    private ITransferRepository _transferRepository;
    public ITransferRepository Transfers =>
        _transferRepository ??= new TransferRepository(_context);

    private ICategoryRepository _categoryRepository;
    public ICategoryRepository Categories =>
        _categoryRepository ??= new CategoryRepository(_context);

    public CommonRepository(ExpenseTrackerDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));

        _categoryRepository = new CategoryRepository(context);
        _transferRepository = new TransferRepository(context);
    }

    public int SaveChanges()
        => _context.SaveChanges();
}
