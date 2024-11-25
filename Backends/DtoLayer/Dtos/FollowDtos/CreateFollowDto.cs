

namespace DtoLayer.Dtos.FollowDtos
{
    public class CreateFollowDto
    {
        public int FollowerId { get; set; }
        public int FollowingId { get; set; }
        public DateTime FollowedAt { get; set; }
    }
}