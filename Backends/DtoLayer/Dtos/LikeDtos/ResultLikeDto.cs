

namespace DtoLayer.Dtos.LikeDtos
{
    public class ResultLikeDto
    {
        public int LikeId { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }
        public DateTime LikedAt { get; set; }
    }
}