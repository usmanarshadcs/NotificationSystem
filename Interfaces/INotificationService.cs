using NotificationSystem.Models;

namespace NotificationSystem.Interfaces
{
    public interface INotificationService
    {
        NotificationResponse SendNotification(NotificationRequest request);
    }
}
