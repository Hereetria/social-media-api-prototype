using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class ViewStory
    {
        public int ViewStoryId { get; set; }

        public int StoryId { get; set; }
        public Story Story { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }

        public DateTime ViewedAt { get; set; }
    }
}
