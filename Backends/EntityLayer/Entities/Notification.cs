using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Notification
    {
        public int NotificationId { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }

        public string Message { get; set; }
        public bool isRead { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
