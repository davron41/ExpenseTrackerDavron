using ExpenseTracker.Domain.Common;

namespace ExpenseTracker.Domain.Entities;

public class ImageFile : EntityBase
{
    public required string Name { get; set; }
    public required byte[] Data { get; set; }
    public required string Type { get; set; }

    public int TransferId { get; set; }
    public required virtual Transfer Transfer { get; set; }
}
