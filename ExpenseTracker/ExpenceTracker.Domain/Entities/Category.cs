using ExpenseTracker.Domain.Common;
using ExpenseTracker.Domain.Enums;

namespace ExpenseTracker.Domain.Entities;

public class Category : AuditableEntity
{
    public string Name { get; set; }
    public string? Description { get; set; }
    public CategoryType Type { get; set; }

    public virtual IEnumerable<Transfer> Transfers { get; set; }
}