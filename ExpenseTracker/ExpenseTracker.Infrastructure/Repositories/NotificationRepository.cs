using ExpenseTracker.Domain.Entities;
using ExpenseTracker.Domain.Interfaces;
using ExpenseTracker.Infrastructure.Persistence;

namespace ExpenseTracker.Infrastructure.Repositories;

class NotificationRepository : INotificationRepository
{
    private readonly ExpenseTrackerDbContext _context;

    public NotificationRepository(ExpenseTrackerDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public List<Notification> GetAll()
    {
        var notifications = _context.Notifications.ToList();

        return notifications;
    }
}
