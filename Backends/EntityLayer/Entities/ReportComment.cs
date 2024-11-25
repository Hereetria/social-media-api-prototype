using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class ReportComment
    {
        public int ReportCommentId { get; set; }

        public string ReporterUserId { get; set; }
        public User ReporterUser { get; set; }

        public int CommentId { get; set; }
        public Comment Comment { get; set; }
        
        public string Reason { get; set; }

        public DateTime ReportedAt { get; set; }
    }
}
