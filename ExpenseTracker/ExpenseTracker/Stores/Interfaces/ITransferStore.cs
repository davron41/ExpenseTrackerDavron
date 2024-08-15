using ExpenseTracker.Domain.Entities;
using ExpenseTracker.ViewModels.Transfer;

namespace ExpenseTracker.Stores.Interfaces
{
    public interface ITransferStore
    {
        List<TransferViewModel> GetAll(string? search);
        TransferViewModel GetById(int id);
        TransferViewModel Create(CreateTransferViewModel transfer);
        void Update(TransferViewModel transfer);
        void Delete(int id);
    }
}
