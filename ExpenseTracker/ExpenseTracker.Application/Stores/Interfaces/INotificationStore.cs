using ExpenseTracker.Application.Requests.Notification;
using ExpenseTracker.Application.ViewModels.Notification;

namespace ExpenseTracker.Application.Stores.Interfaces;

public interface INotificationStore
{
    List<NotificationViewModel> GetAll(GetNotificationsRequest request);
}
