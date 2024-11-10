using ExpenseTracker.Application.Requests.ApplicationUser;

namespace ExpenseTracker.Application.Stores.Interfaces;

public interface IUserStore
{
    Task Update(UpdateApplicationUserRequest request);
}