using ExpenseTracker.Domain.Entities;

namespace ExpenseTracker.Domain.Interfaces
{
    public interface ITransferRepository : IRepositoryBase<Transfer>
    {
        List<Transfer> GetAll(int? categoryId, string? search);
        List<Transfer> GetAll(decimal? minAmount, decimal? maxAmount);

    }
}
