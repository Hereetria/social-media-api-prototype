using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Media
    {
        public int MediaId { get; set; }
        public string PhotoUrl { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }

        public DateTime UploadedAt { get; set; }
    }
}
