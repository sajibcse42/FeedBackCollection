using FeedBackCollection.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeedBackCollection.Service
{
    public interface IFeedBackCollectionService
    {
        Task<object> GetAll();
    }
    public class FeedBackCollectionService : IFeedBackCollectionService
    {
        private readonly FeedBackCollectionDbContext _context;

        public FeedBackCollectionService(FeedBackCollectionDbContext context)
        {
            _context = context;
        }

        //can not fininsh need to work
        public async Task<object> GetAll()
        {
            var datamodel = (from c in _context.CommentsInfo
                             join p in _context.PostInfo on c.PostId equals p.Id
                             join u in _context.UserInfo on p.UserRole equals u.Role
                             select new
                             {
                                 c.Likes,
                                 c.Dislike,
                                 c.PostId,
                                 Like = _context.CommentsInfo.Where(s => s.Likes == true && s.PostId==c.PostId).Count(),
                                 Dislikes = _context.CommentsInfo.Where(t => t.Dislike == true && t.PostId == c.PostId).Count(),
                                 p.Post,
                                 p.UserRole,
                                 p.CreatedAt,
                                 c.CommentUser,

                             }).GroupBy(p => p.PostId).ToList();
           
            return datamodel;

        }
    }

}
