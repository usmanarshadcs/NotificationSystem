using Microsoft.AspNetCore.Mvc;
using NotificationSystem.Interfaces;
using NotificationSystem.Models;
using System.Text.Json;
using System.Threading.Channels;

namespace NotificationSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotificationServiceController : ControllerBase
    {
        private readonly INotificationService _notificationService;

        private readonly ILogger<NotificationServiceController> _logger;

        public NotificationServiceController(INotificationService notificationService,ILogger<NotificationServiceController> logger)
        {
            _logger = logger;
            _notificationService = notificationService;
        }

        [HttpPost]
        public IActionResult SendNotification([FromBody] NotificationRequest request)
        {
            try
            {
                var response = _notificationService.SendNotification(request);
                if (response.IsSent)
                {
                    return Ok(response);
                }
                else
                {
                    return BadRequest(response);
                }
            }
            catch (Exception ex)
            {
                var jsonRequest = JsonSerializer.Serialize(request);
                _logger.LogError($"Error sending notification Ex: {ex.Message} & request: {jsonRequest} ");
                return StatusCode(500, "Something went Wrong, Please Try Again");
            }
           
        }
    }
}