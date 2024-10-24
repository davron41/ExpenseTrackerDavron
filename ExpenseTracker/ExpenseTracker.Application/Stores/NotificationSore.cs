using ExpenseTracker.Application.Mappings;
using ExpenseTracker.Application.Requests.Notification;
using ExpenseTracker.Application.Stores.Interfaces;
using ExpenseTracker.Application.ViewModels.Notification;
using ExpenseTracker.Domain.Interfaces;

namespace ExpenseTracker.Application.Stores;

public class NotificationSore : INotificationStore
{
    private readonly ICommonRepository _commonRepository;

    public NotificationSore(ICommonRepository commonRepository)
    {
        _commonRepository = commonRepository ?? throw new ArgumentNullException(nameof(commonRepository));
    }
    public List<NotificationViewModel> GetAll(GetNotificationsRequest request)
    {
        ArgumentNullException.ThrowIfNull(nameof(request));

        var notifications = _commonRepository.Notifications.GetAll();

        var viewModels = notifications
            .Select(x => x.ToViewModel())
            .ToList();

        return viewModels;
    }
}
