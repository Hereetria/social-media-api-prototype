

namespace DtoLayer.Dtos.ReportCommentDtos
{
    public class ResultReportCommentDto
    {
        public int ReportCommentId { get; set; }
        public int ReporterUserId { get; set; }
        public int CommentId { get; set; }
        public string Reason { get; set; }
        public DateTime ReportedAt { get; set; }
    }
}