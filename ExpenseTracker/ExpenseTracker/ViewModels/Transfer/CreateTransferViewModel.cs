using ExpenseTracker.Domain.Enums;

namespace ExpenseTracker.ViewModels.Transfer
{
    public class CreateTransferViewModel
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        public decimal Amount { get; set; }
        public TransferType Type { get; set; }
        public int CategoryId { get; set; }
    }
}
