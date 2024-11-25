

namespace DtoLayer.Dtos.ReportCommentDtos
{
    public class CreateReportCommentDto
    {
        public int ReporterUserId { get; set; }
        public int CommentId { get; set; }
        public string Reason { get; set; }
        public DateTime ReportedAt { get; set; }
    }
}