using NotificationSystem.Interfaces;
using NotificationSystem.Models;

namespace NotificationSystem.Classes
{
    public class SmsChannel : ISmsChannel
    {
        public NotificationResponse SendSms(NotificationRequest request)
        {
            // 1. we can write send logic here 
            // 2. we can also store request information in database for logging purpose and retry mechanism (hangfire or some other background job)
            return new NotificationResponse() { IsSent = true};// response will true in case of success otherwise will return false
        }
    }
}
