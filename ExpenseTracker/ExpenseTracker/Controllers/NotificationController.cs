using ExpenseTracker.Application.Requests.Notification;
using ExpenseTracker.Application.Stores.Interfaces;
using ExpenseTracker.Application.ViewModels.Notification;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.Controllers
{
    public class NotificationController : Controller
    {
        private readonly INotificationStore _notificationStore;

        public NotificationController(INotificationStore notificationStore)
        {
            _notificationStore = notificationStore ?? throw new ArgumentNullException(nameof(notificationStore));
        }

        public IActionResult Index(GetNotificationsRequest request)
        {
            var notifications = _notificationStore.GetAll(request);

            notifications.Add(new NotificationViewModel
                {
                    Id = 1,
                    Title = "Notification 1",
                    Body = "This is the body of notification 1",
                    IsRead = false,
                    Date = DateTime.Now.AddHours(-5)
                });
            notifications.Add(new NotificationViewModel
            {
                Id = 2,
                Title = "Notification 2",
                Body = "This is the body of notification 2",
                IsRead = false,
                Date = DateTime.Now.AddDays(-2)
            });
            notifications.Add(new NotificationViewModel
            {
                Id = 3,
                Title = "Notification 3",
                Body = "This is the body of notification 2",
                IsRead = true,
                Date = DateTime.Now.AddDays(-2)
            });
            notifications.Add(new NotificationViewModel
            {
                Id = 4,
                Title = "Notification 2",
                Body = "This is the body of notification 2",
                IsRead = false,
                Date = DateTime.Now.AddDays(-2)
            });
            notifications.Add(new NotificationViewModel
            {
                Id = 5,
                Title = "Notification 2",
                Body = "This is the body of notification 2",
                IsRead = true,
                Date = DateTime.Now.AddDays(-2)
            });
            notifications.Add(new NotificationViewModel
            {
                Id = 6,
                Title = "Notification 2",
                Body = "This is the body of notification 2",
                IsRead = true,
                Date = DateTime.Now.AddDays(-2)
            });
            notifications.Add(new NotificationViewModel
            {
                Id = 7,
                Title = "Notification 2",
                Body = "This is the body of notification 2",
                IsRead = true,
                Date = DateTime.Now.AddDays(-2)
            });
            notifications.Add(new NotificationViewModel
            {
                Id = 8,
                Title = "Notification 2",
                Body = "This is the body of notification 2",
                IsRead = true,
                Date = DateTime.Now.AddDays(-2)
            });
            notifications.Add(new NotificationViewModel
            {
                Id = 9,
                Title = "Notification 2",
                Body = "This is the body of notification 2",
                IsRead = false,
                Date = DateTime.Now.AddDays(-2)
            });
            notifications.Add(new NotificationViewModel
            {
                Id = 10,
                Title = "Notification 2",
                Body = "This is the body of notification 2",
                IsRead = false,
                Date = DateTime.Now.AddDays(-2)
            });
            notifications.Add(new NotificationViewModel
            {
                Id =11,
                Title = "Notification 2",
                Body = "This is the body of notification 2",
                IsRead = false,
                Date = DateTime.Now.AddDays(-2)
            });

            return View(notifications);
        }
    }
}
