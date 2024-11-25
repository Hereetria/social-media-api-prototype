

namespace DtoLayer.Dtos.PostDtos
{
    public class CreatePostDto
    {
        public string Caption { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UserId { get; set; }
    }
}