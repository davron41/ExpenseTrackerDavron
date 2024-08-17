namespace ExpenseTracker.ViewModels.Transfer;

public class CreateTransferViewModel
{
    public string? Note { get; set; }
    public decimal Amount { get; set; }
    public int CategoryId { get; set; }
}
