using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FeedBackCollection.Model
{
    public class UserInfo
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        
        public string Role { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
    
    }
}
