

namespace DtoLayer.Dtos.CommentDtos
{
    public class CreateCommentDto
    {
        public string Content { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }
        public DateTime CommentedAt { get; set; }
    }
}