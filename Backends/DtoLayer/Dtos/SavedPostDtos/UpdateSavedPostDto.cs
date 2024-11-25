

namespace DtoLayer.Dtos.SavedPostDtos
{
    public class UpdateSavedPostDto
    {
        public int SavedPostId { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }
        public DateTime SavedAt { get; set; }
    }
}