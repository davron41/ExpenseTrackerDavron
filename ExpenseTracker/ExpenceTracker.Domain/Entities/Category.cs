namespace ExpenseTracker.Domain.Entities
{
    public class Category
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public virtual IEnumerable<Transfer> Transfers { get; set; }
    }
}
