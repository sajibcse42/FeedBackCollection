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
                             join p in _context.CommentsInfo on c.PostId equals p.Id
                             select new
                             {
                                 c.Likes,
                                 c.Dislike,
                                 c.PostId,
                                 p.CreatedAt,
                                 c.CommentUser,

                             }).ToList();
            //can not fininsh by time need to work
            return datamodel;

        }
    }

}
