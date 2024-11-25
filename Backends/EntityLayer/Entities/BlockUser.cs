using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class BlockUser
    {
        public int BlockUserId { get; set; }

        public string BlockingUserId { get; set; }
        public User BlockingUser { get; set; }

        public string BlockedUserId { get; set; }
        public User BlockedUser { get; set; }

        public DateTime BlockedAt { get; set; }
    }
}
