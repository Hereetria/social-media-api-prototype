

namespace DtoLayer.Dtos.BlockUserDtos
{
    public class ResultBlockUserByIdDto
    {
        public int BlockUserId { get; set; }
        public int BlockingUserId { get; set; }
        public int BlockedUserId { get; set; }
        public DateTime BlockedAt { get; set; }
    }
}