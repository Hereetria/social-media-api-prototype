

namespace DtoLayer.Dtos.NotificationDtos
{
    public class CreateNotificationDto
    {
        public int UserId { get; set; }
        public string Message { get; set; }
        public bool isRead { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}