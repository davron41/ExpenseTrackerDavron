namespace ExpenseTracker.Application.ViewModels.Notification;

public class NotificationViewModel
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
    public bool IsRead { get; set; }
    public DateTime Date { get; set; }
}
