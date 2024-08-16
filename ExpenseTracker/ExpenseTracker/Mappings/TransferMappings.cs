using ExpenseTracker.Domain.Entities;
using ExpenseTracker.ViewModels.Transfer;

namespace ExpenseTracker.Mappings
{
    public static class TransferMappings
    {
        public static TransferViewModel ToViewModel(this Transfer transfer)
        {
            return new TransferViewModel
            {
                Amount = transfer.Amount,
                Description = transfer.Description,
                Id = transfer.Id,
                Title = transfer.Title,
                Type = transfer.Type,
                CategoryId = transfer.CategoryId,
            };
        }
        public static Transfer ToEntity(this CreateTransferViewModel transfer)
        {
            return new Transfer
            {
                Amount = transfer.Amount,
                Description = transfer.Description,
                Title = transfer.Title,
                Type = transfer.Type,
                CategoryId=transfer.CategoryId,
            };
        }
        public static Transfer ToEntity(this TransferViewModel transfer)
        {
            return new Transfer
            {
                Amount = transfer.Amount,
                Description = transfer.Description,
                Title = transfer.Title,
                Type = transfer.Type,
                Id = transfer.Id,
                CategoryId=transfer.CategoryId
            };
        }
    }
}
