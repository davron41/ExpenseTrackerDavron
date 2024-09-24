using ExpenseTracker.Application.Requests.Common;

namespace ExpenseTracker.Application.Requests.Transfer;

public record TransferRequest(Guid UserId, int TransferId) : UserRequest(UserId: UserId);
