using ExpenseTracker.ViewModels.Transfer;

namespace ExpenseTracker.Stores.Interfaces
{
    public interface ITransferStore
    {
        List<TransferViewModel> GetAll(int? categoryId, string? search);
        TransferViewModel GetById(int id);
        UpdateTransferViewModel GetForUpdate(int id);
        TransferViewModel Create(CreateTransferViewModel transfer, IEnumerable<IFormFile> attachments);
        void Update(UpdateTransferViewModel transfer);
        void Delete(int id);
    }
}
