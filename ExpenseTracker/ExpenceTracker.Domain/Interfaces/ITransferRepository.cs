using ExpenseTracker.Domain.Entities;

namespace ExpenseTracker.Domain.Interfaces
{
    public interface ITransferRepository : IRepositoryBase<Transfer>
    {
        List<Transfer> GetAll(string? search);
        List<Transfer> GetAll(decimal? minAmount, decimal? maxAmount);

    }
}
