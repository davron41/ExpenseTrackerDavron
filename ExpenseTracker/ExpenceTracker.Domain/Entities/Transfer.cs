using ExpenseTracker.Domain.Common;

namespace ExpenseTracker.Domain.Entities;

public class Transfer : AuditableEntity
{
    public string? Note { get; set; }
    public decimal Amount { get; set; }

    public int CategoryId { get; set; }
    public virtual Category Category { get; set; }
}
