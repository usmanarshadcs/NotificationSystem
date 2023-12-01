using System.ComponentModel.DataAnnotations;

namespace NotificationSystem.Models
{
    public class NotificationRequest
    {
        [Required(ErrorMessage = "Receiver Id is required")]
        public string Receiver { get; set; }

        [Required(ErrorMessage = "MessageText Id is required")]
        public string MessageText { get; set; }
        [Range(1, 3, ErrorMessage = "Please enter valid Channel ( 1.Email 2.Sms 3.Push Notification)")]
        public int NotificationType { get; set; }
    }
}
