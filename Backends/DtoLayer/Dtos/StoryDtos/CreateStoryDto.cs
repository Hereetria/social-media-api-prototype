

namespace DtoLayer.Dtos.StoryDtos
{
    public class CreateStoryDto
    {
        public string ImageUrl { get; set; }
        public DateTime ExpirationTime { get; set; }
        public int UserId { get; set; }
        public DateTime DateTime { get; set; }
    }
}