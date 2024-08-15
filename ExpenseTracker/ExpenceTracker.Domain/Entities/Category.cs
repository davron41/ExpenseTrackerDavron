using ExpenseTracker.Domain.Common;

namespace ExpenseTracker.Domain.Entities
{
    public class Category : AuditableEntity
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public virtual IEnumerable<Transfer> Transfers { get; set; }
    }
}
