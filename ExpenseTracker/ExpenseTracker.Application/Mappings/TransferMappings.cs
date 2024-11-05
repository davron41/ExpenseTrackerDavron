using ExpenseTracker.Application.Requests.Transfer;
using ExpenseTracker.Application.ViewModels.Transfer;
using ExpenseTracker.Domain.Entities;

namespace ExpenseTracker.Application.Mappings;

public static class TransferMappings
{
    public static TransferViewModel ToViewModel(this Transfer transfer)
    {
        return new TransferViewModel
        {
            Id = transfer.Id,
            Note = transfer.Notes,
            Amount = transfer.Amount,
            Date = transfer.Date,
            Category = transfer.Category.ToViewModel(),
            Wallet = transfer.Wallet.ToViewModel(),
            Images = transfer.Images.Select(x => Convert.ToBase64String(x.Data)).ToList()
        };
    }

    public static Transfer ToEntity(this CreateTransferRequest transfer)
    {
        return new Transfer
        {
            Notes = transfer.Notes,
            Amount = transfer.Amount,
            Date = transfer.Date,
            CategoryId = transfer.CategoryId,
            Category = null,
            Wallet = null!,
            WalletId = transfer.WalletId
        };
    }
    public static UpdateTransferRequest ToUpdateRequest(this TransferViewModel viewModel)
    {
        return new UpdateTransferRequest(
        UserId: viewModel.Wallet.UserId,  
        Id: viewModel.Id,
        CategoryId: viewModel.Category.Id,         
        WalletId: viewModel.Wallet.Id,           
        Notes: viewModel.Note,
        Amount: viewModel.Amount,
        Date: viewModel.Date
        );
    }


    public static Transfer ToEntity(this UpdateTransferRequest request)
    {
        return new Transfer
        {
            Id = request.Id,
            Notes = request.Notes,
            Amount = request.Amount,
            Date = request.Date,
            CategoryId = request.CategoryId,
            WalletId = request.WalletId,
            Category = null,
            Wallet = null!,
        };
    }
}
