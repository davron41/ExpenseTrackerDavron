using ExpenseTracker.Application.ViewModels.Notification;
using ExpenseTracker.Domain.Entities;

namespace ExpenseTracker.Application.Mappings;

public static class NotificationMappings
{
    public static NotificationViewModel ToViewModel(this Notification notification)
    {
        return new NotificationViewModel()
        {
            Id = notification.Id,
            Body = notification.Body,
            Title = notification.Title,
            RedirectUrl = notification.RedirectUrl,
            Date = notification.CreatedAt,
        };
    }
}
