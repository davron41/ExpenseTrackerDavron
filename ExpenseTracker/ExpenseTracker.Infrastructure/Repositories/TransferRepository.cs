using ExpenseTracker.Domain.Entities;
using ExpenseTracker.Domain.Interfaces;

namespace ExpenseTracker.Infrastructure.Repositories
{
    public class TransferRepository : RepositoryBase<Transfer>, ITransferRepository
    {
        public TransferRepository(ExpenseTrackerDbContext context) : base(context) { }

        public List<Transfer> GetAll(string? search)
        {

            if (string.IsNullOrEmpty(search))
            {
                return GetAll();
            }

            var transfers = _context.Transfers.Where(x => x.Title.Contains(search) ||
            (x.Description != null && x.Description.Contains(search))
            ).ToList();

            return transfers;
        }

        public List<Transfer> GetAll(decimal? minAmount, decimal? maxAmount)
        {
            if (minAmount is null && maxAmount is null)
            {
                return GetAll();
            }

            var transfers = _context.Transfers.Where(x => x.Amount >= minAmount && x.Amount <= maxAmount ||
            ((minAmount == null && maxAmount != null) && x.Amount <= maxAmount) ||
            ((minAmount != null && maxAmount == null) && x.Amount >= minAmount)
            ).ToList();

            return transfers;
        }
    }
}
