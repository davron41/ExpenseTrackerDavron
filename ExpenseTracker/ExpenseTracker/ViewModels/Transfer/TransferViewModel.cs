using ExpenseTracker.ViewModels.Category;

namespace ExpenseTracker.ViewModels.Transfer;

public class TransferViewModel
{
    public int Id { get; set; }
    public string? Note { get; set; }
    public decimal Amount { get; set; }
    public CategoryViewModel Category { get; set; }
}
