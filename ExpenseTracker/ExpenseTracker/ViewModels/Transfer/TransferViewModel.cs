using ExpenseTracker.Domain.Enums;

namespace ExpenseTracker.ViewModels.Transfer
{
    public class TransferViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }=string.Empty;
        public string? Description { get; set; }
        public decimal Amount { get; set; }
        public TransferType Type { get; set; }
        public int CategoryId { get; set; }
    }
}
