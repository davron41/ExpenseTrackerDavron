namespace ExpenseTracker.Application.Requests.Transfer;

public record UpdateTransferRequest(
    Guid UserId,
    int CategoryId,
    int TransferId,
    string? Notes,
    decimal Amount,
    DateTime Date)
    : CreateTransferRequest(
        UserId: UserId,
        CategoryId: CategoryId,
        Notes: Notes,
        Amount: Amount,
        Date: Date);
