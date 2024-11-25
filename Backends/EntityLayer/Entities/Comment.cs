using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string Content { get; set; }

        public int PostId { get; set; }
        public Post Post { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }

        public DateTime CommentedAt { get; set; }

        public ICollection<ReportComment> ReportComments { get; set; } = new List<ReportComment>(); 
    }
}
