using ExpenseTracker.Domain.Entities;
using ExpenseTracker.ViewModels.Transfer;

namespace ExpenseTracker.Mappings;

public static class TransferMappings
{
    public static TransferViewModel ToViewModel(this Transfer transfer)
    {
        return new TransferViewModel
        {
            Id = transfer.Id,
            Note = transfer.Note,
            Amount = transfer.Amount,
            Category = transfer.Category.ToViewModel()
        };
    }

    public static UpdateTransferViewModel ToUpdateViewModel(this Transfer transfer)
    {
        return new UpdateTransferViewModel
        {
            Id = transfer.Id,
            Note = transfer.Note,
            Amount = transfer.Amount,
            CategoryId = transfer.Category.Id
        };
    }

    public static Transfer ToEntity(this CreateTransferViewModel transfer)
    {
        return new Transfer
        {
            Note = transfer.Note,
            Amount = transfer.Amount,
            CategoryId = transfer.CategoryId,
        };
    }

    public static Transfer ToEntity(this UpdateTransferViewModel transfer)
    {
        return new Transfer
        {
            Id = transfer.Id,
            Note = transfer.Note,
            Amount = transfer.Amount,
            CategoryId = transfer.CategoryId
        };
    }
}
