using ExpenseTracker.Domain.Entities;

namespace ExpenseTracker.Domain.Interfaces;

public interface IWalletRepository : IRepositoryBase<Wallet>
{
    List<Wallet> GetAll(Guid userId, string? search);
    Wallet GetById(int id, Guid userId);
    void Delete(int id, Guid userId);
}
