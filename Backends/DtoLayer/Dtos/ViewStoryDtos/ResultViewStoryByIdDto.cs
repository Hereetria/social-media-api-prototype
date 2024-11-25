

namespace DtoLayer.Dtos.ViewStoryDtos
{
    public class ResultViewStoryByIdDto
    {
        public int ViewStoryId { get; set; }
        public int StoryId { get; set; }
        public int UserId { get; set; }
        public DateTime ViewedAt { get; set; }
    }
}