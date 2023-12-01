using NotificationSystem.Models;

namespace NotificationSystem.Interfaces
{
    public interface ISmsChannel
    {
        NotificationResponse SendSms(NotificationRequest request);
    }
}
