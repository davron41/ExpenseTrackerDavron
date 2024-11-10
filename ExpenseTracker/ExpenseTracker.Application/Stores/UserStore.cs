using ExpenseTracker.Application.Stores.Interfaces;
using Microsoft.AspNetCore.Identity;
using ExpenseTracker.Application.Requests.ApplicationUser;
using ExpenseTracker.Domain.Entities;

namespace ExpenseTracker.Application.Stores
{
    public class UserStore : IUserStore
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UserStore(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
        }

        public async Task Update(UpdateApplicationUserRequest request)
        {
            var user = await _userManager.FindByIdAsync(request.Id.ToString());

            if (user == null)
            {
                throw new KeyNotFoundException($"User with ID {request.Id} not found.");
            }

            user.UserName = request.UserName;
            user.Email = request.Email;
            user.PhoneNumber = request.PhoneNumber;

            var result = await _userManager.UpdateAsync(user);

            if (!result.Succeeded)
            {
                var errors = string.Join(", ", result.Errors.Select(e => e.Description));
                throw new Exception($"Error when updating user: {errors}");
            }
        }
    }
}
