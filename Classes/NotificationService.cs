using NotificationSystem.Interfaces;
using NotificationSystem.Models;
using System.Linq.Expressions;

namespace NotificationSystem.Classes
{
    public class NotificationService : INotificationService
    {
        private readonly IEmailChannel _emailChannel;
        private readonly ISmsChannel _smsChannel;
        private readonly INotificationChannel _notificationChannel;
        public NotificationService(IEmailChannel emailChannel, ISmsChannel smsChannel, INotificationChannel notification)
        {
            _emailChannel = emailChannel;
            _smsChannel = smsChannel;
            _notificationChannel = notification;

        }
        public NotificationResponse SendNotification(NotificationRequest request)
        {

            NotificationType channelSelect = (NotificationType)request.NotificationType;//  select channel based on request 
            switch (channelSelect)
            {
                case NotificationType.Email:

                    return _emailChannel.SendEmail(request);
                case NotificationType.Sms:
                    return _smsChannel.SendSms(request);
                case NotificationType.PushNotification:
                    return _notificationChannel.SendNotification(request);
                default:
                    var response = new NotificationResponse()
                    {
                        IsSent = false,
                        ErrorMsg = "Please choose correct / available Channel ( 1.Email 2.Sms 3.Push Notification)"
                    };
                    return response;

            }





        }
    }
}
