using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Story
    {
        public int StoryId { get; set; }
        public string ImageUrl { get; set; }
        public DateTime ExpirationTime { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }
        
        public DateTime DateTime { get; set; }

        public ICollection<ViewStory> ViewStories { get; set; } = new List<ViewStory>();
    }
}
