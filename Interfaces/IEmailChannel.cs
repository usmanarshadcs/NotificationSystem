using NotificationSystem.Models;

namespace NotificationSystem.Interfaces
{
    public interface IEmailChannel
    {
        NotificationResponse SendEmail(NotificationRequest request);
    }
}
