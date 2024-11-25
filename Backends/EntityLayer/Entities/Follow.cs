using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Follow
    {
        public int FollowId { get; set; }

        public string FollowerId { get; set; }
        public User Follower { get; set; }

        public string FollowingId { get; set; }
        public User Following { get; set; }

        public DateTime FollowedAt { get; set; }
    }
}
