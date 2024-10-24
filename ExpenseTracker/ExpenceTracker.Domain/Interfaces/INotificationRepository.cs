using ExpenseTracker.Domain.Entities;

namespace ExpenseTracker.Domain.Interfaces;

public interface INotificationRepository
{
    List<Notification> GetAll();
}
