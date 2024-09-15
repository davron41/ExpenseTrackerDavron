using ExpenseTracker.Domain.Entities;

namespace ExpenseTracker.Domain.Interfaces;

public interface IImageFileRepository : IRepositoryBase<ImageFile>
{
    List<ImageFile> GetByTransferId(int transferId);
}
