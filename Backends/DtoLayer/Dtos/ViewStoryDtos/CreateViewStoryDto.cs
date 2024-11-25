

namespace DtoLayer.Dtos.ViewStoryDtos
{
    public class CreateViewStoryDto
    {
        public int StoryId { get; set; }
        public int UserId { get; set; }
        public DateTime ViewedAt { get; set; }
    }
}