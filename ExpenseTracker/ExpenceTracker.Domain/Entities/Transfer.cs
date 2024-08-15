using ExpenseTracker.Domain.Common;
using ExpenseTracker.Domain.Enums;

namespace ExpenseTracker.Domain.Entities
{
    public class Transfer : AuditableEntity
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        public decimal Amount { get; set; }
        public TransferType Type { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
