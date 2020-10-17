using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FeedBackCollection.Model
{
    public class PostInfo
    {
        [Key]
        public int Id { get; set; }
        public string Post { get; set; }
        public string UserRole { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
       
    }
}
