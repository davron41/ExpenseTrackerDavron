using ExpenseTracker.Application.Requests.User;
using ExpenseTracker.Application.ViewModels.User;
using ExpenseTracker.Domain.Entities;

namespace ExpenseTracker.Application.Mappings;

public static class UserMappings
{
    public static UserViewModel ToViewModel(this ApplicationUser user)
    {
        return new UserViewModel
        {
            Id = user.Id,
            UserName = user.UserName!,
            Email = user.Email!,
            PhoneNumber = user.PhoneNumber
        };
    }

    public static ApplicationUser ToEntity(this CreateUserRequest request)
    {
        return new ApplicationUser
        {
            UserName = request.UserName,
            Email = request.Email,
            PhoneNumber = request.PhoneNumber
        };
    }

    public static ApplicationUser ToEntity(this UpdateUserRequest request)
    {
        return new ApplicationUser
        {
            UserName = request.UserName,
            Email = request.Email,
            PhoneNumber = request.PhoneNumber
        };
    }
}