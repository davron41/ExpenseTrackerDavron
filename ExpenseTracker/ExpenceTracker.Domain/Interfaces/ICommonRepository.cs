namespace ExpenseTracker.Domain.Interfaces;

public interface ICommonRepository
{
    ITransferRepository Transfers { get; }
    ICategoryRepository Categories { get; }
    public int SaveChanges();
}
