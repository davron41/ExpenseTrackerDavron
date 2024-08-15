using ExpenseTracker.Domain.Interfaces;

namespace ExpenseTracker.Infrastructure.Repositories
{
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
            context = _context ?? throw new ArgumentNullException(nameof(context));

            _categoryRepository = new CategoryRepository(_context);
            _transferRepository = new TransferRepository(_context);
        }

        public int SaveChanges()
            => _context.SaveChanges();
    }
}
