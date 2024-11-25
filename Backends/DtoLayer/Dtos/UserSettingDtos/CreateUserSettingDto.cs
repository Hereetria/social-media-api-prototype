

namespace DtoLayer.Dtos.UserSettingDtos
{
    public class CreateUserSettingDto
    {
        public int UserId { get; set; }
        public bool IsPrivate { get; set; }
        public bool ReceiveNotifications { get; set; }
        public bool ShowActivityStatus { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}