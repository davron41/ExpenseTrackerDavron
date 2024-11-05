using ExpenseTracker.Application.Mappings;
using ExpenseTracker.Application.Requests.Notification;
using ExpenseTracker.Application.Stores.Interfaces;
using ExpenseTracker.Application.ViewModels.Notification;
using ExpenseTracker.Domain.Interfaces;

namespace ExpenseTracker.Application.Stores;

public class NotificationStore : INotificationStore
{
    private readonly ICommonRepository _commonRepository;

    public NotificationStore(ICommonRepository commonRepository)
    {
        _commonRepository = commonRepository ?? throw new ArgumentNullException(nameof(commonRepository));
    }

    public List<NotificationViewModel> GetAll(GetNotificationsRequest request)
    {
        ArgumentNullException.ThrowIfNull(nameof(request));
        
        var notifications = _commonRepository.Notifications.GetAll(request.UserId);

        var viewModels = notifications
            .Select(x => x.ToViewModel())
            .ToList();

        return viewModels;
    }
}
