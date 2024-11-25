

namespace DtoLayer.Dtos.CommentDtos
{
    public class ResultCommentByIdDto
    {
        public int CommentId { get; set; }
        public string Content { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }
        public DateTime CommentedAt { get; set; }
    }
}