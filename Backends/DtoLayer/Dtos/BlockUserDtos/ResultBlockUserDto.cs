

namespace DtoLayer.Dtos.BlockUserDtos
{
    public class ResultBlockUserDto
    {
        public int BlockUserId { get; set; }
        public int BlockingUserId { get; set; }
        public int BlockedUserId { get; set; }
        public DateTime BlockedAt { get; set; }
    }
}