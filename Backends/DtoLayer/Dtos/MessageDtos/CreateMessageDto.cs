

namespace DtoLayer.Dtos.MessageDtos
{
    public class CreateMessageDto
    {
        public string Content { get; set; }
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public DateTime SentAt { get; set; }
    }
}