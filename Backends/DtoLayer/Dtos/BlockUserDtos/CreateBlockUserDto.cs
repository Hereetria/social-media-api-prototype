

namespace DtoLayer.Dtos.BlockUserDtos
{
    public class CreateBlockUserDto
    {
        public int BlockingUserId { get; set; }
        public int BlockedUserId { get; set; }
        public DateTime BlockedAt { get; set; }
    }
}