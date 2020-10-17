using FeedBackCollection.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeedBackCollection
{
    public class FeedBackCollectionDbContext: DbContext
    {
        public FeedBackCollectionDbContext(DbContextOptions<FeedBackCollectionDbContext> options)
         : base(options)
        {
        }
        public virtual DbSet<UserInfo> UserInfo { get; set; }
        public virtual DbSet<PostInfo> PostInfo { get; set; }
        public virtual DbSet<CommentsInfo> CommentsInfo { get; set; }
    }
}
