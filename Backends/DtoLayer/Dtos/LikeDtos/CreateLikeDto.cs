

namespace DtoLayer.Dtos.LikeDtos
{
    public class CreateLikeDto
    {
        public int PostId { get; set; }
        public int UserId { get; set; }
        public DateTime LikedAt { get; set; }
    }
}