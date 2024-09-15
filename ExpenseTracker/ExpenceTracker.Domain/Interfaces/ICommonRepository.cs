namespace ExpenseTracker.Domain.Interfaces;

public interface ICommonRepository
{
    ITransferRepository Transfers { get; }
    ICategoryRepository Categories { get; }
    IImageFileRepository ImageFiles { get; }

    public int SaveChanges();
}
