using ExpenseTracker.Domain.Common;
using ExpenseTracker.Domain.Enums;

namespace ExpenseTracker.Domain.Entities;

public class Category : AuditableEntity
{
    public required string Name { get; set; }
    public string? Description { get; set; }
    public CategoryType Type { get; set; }

    public virtual IEnumerable<Transfer> Transfers { get; set; }

    public Category()
    {
        Transfers = new HashSet<Transfer>();
    }
}