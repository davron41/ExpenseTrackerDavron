using ExpenseTracker.ViewModels.Transfer;

namespace ExpenseTracker.Stores.Interfaces
{
    public interface ITransferStore
    {
        List<TransferViewModel> GetAll(string? search);
        TransferViewModel GetById(int id);
        UpdateTransferViewModel GetForUpdate(int id);
        TransferViewModel Create(CreateTransferViewModel transfer);
        void Update(UpdateTransferViewModel transfer);
        void Delete(int id);
    }
}
