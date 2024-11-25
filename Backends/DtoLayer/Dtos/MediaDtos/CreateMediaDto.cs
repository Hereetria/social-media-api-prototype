

namespace DtoLayer.Dtos.MediaDtos
{
    public class CreateMediaDto
    {
        public string PhotoUrl { get; set; }
        public int UserId { get; set; }
        public DateTime UploadedAt { get; set; }
    }
}