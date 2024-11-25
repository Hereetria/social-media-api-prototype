

namespace DtoLayer.Dtos.FollowDtos
{
    public class ResultFollowByIdDto
    {
        public int FollowId { get; set; }
        public int FollowerId { get; set; }
        public int FollowingId { get; set; }
        public DateTime FollowedAt { get; set; }
    }
}