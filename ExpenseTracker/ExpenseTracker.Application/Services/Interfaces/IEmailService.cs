using MimeKit;

namespace ExpenseTracker.Application.Services.Interfaces;

public interface IEmailService
{
    void SendEmail(List<MailboxAddress> to, string subject, string content);
}
