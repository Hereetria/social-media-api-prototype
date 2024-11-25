

namespace DtoLayer.Dtos.MediaDtos
{
    public class ResultMediaDto
    {
        public int MediaId { get; set; }
        public string PhotoUrl { get; set; }
        public int UserId { get; set; }
        public DateTime UploadedAt { get; set; }
    }
}