

namespace DtoLayer.Dtos.UserSettingDtos
{
    public class UpdateUserSettingDto
    {
        public int UserSettingId { get; set; }
        public int UserId { get; set; }
        public bool IsPrivate { get; set; }
        public bool ReceiveNotifications { get; set; }
        public bool ShowActivityStatus { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}