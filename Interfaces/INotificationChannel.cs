using NotificationSystem.Models;

namespace NotificationSystem.Interfaces
{
    public interface INotificationChannel
    {
        NotificationResponse SendNotification(NotificationRequest request);
    }
}
