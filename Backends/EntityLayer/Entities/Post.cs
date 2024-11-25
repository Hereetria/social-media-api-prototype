using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Post
    {
        public int PostId { get; set; }
        public string Caption { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreatedAt { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }

        public ICollection<Like> Likes { get; set; } = new List<Like>();
        
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();

        public ICollection<SavedPost> SavedPosts { get; set; } = new List<SavedPost>();

        public ICollection<PostTag> PostTags { get; set; } = new List<PostTag>();
    }
}
