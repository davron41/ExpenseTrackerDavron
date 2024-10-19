using MimeKit;

namespace ExpenseTracker.Application.Services.Interfaces;

public interface IEmailService
{
    void SendEmail(List<MailboxAddress> to, string subject, string content);
    void SendConfirmation(string userName, string fallbackUrl);
    void SendResetPassword(string userName, string fallbackUrl);
}
