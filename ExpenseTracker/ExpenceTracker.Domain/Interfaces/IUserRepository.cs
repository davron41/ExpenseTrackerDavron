using ExpenseTracker.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace ExpenseTracker.Domain.Interfaces;

public interface IUserRepository
{
    List<ApplicationUser> GetAll();
    ApplicationUser GetById(Guid id);
    ApplicationUser? GetByEmail(string email);
}
