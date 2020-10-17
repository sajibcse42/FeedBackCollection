using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FeedBackCollection.Model
{
    public class CommentsInfo
    {
        [Key]
        public int Id { get; set; }
        public int PostId { get; set; }
        public string Comments { get; set; }
        public bool Likes { get; set; }
        public string CommentUser { get; set; }
        public bool Dislike { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
    }
}
