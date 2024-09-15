using ExpenseTracker.Domain.Common;

namespace ExpenseTracker.Domain.Entities;

public class Transfer : AuditableEntity
{
    public string? Note { get; set; }
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }

    public int CategoryId { get; set; }
    public required virtual Category Category { get; set; }

    public virtual ICollection<ImageFile> Images { get; set; }

    public Transfer()
    {
        Images = [];
    }
}