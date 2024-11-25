

namespace DtoLayer.Dtos.SavedPostDtos
{
    public class CreateSavedPostDto
    {
        public int UserId { get; set; }
        public int PostId { get; set; }
        public DateTime SavedAt { get; set; }
    }
}