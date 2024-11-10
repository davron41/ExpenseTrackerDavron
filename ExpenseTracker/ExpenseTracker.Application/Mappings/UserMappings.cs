using ExpenseTracker.Application.Requests.ApplicationUser;
using ExpenseTracker.Application.ViewModels.ApplicationUser;
using ExpenseTracker.Domain.Entities;

namespace ExpenseTracker.Application.Mappings;

public static class UserMappings
{
    public static ApplicationUserViewModel ToViewModel(this ApplicationUser user)
    {
        return new ApplicationUserViewModel()
        {
            Id = user.Id,
            UserName = user.UserName!,
            Email = user.Email!,
            PhoneNumber = user.PhoneNumber
        };
    }

    public static ApplicationUser ToEntity(this UpdateApplicationUserRequest request)
    {
        return new ApplicationUser
        {
            UserName = request.UserName,
            Email = request.Email,
            PhoneNumber = request.PhoneNumber
        };
    }
}