using FeedBackCollection.Model;
using System;
using System.Threading.Tasks;

namespace FeedBackCollection.Service
{
  public interface ICommentsInfoService
    {
        Task<int> Add(CommentsInfo entity);
        Task<int> Delete(int? id);
        Task<int> Update(CommentsInfo entity);
    }
    public class CommentsInfoService : ICommentsInfoService
    {
        private readonly FeedBackCollectionDbContext _context;

        public CommentsInfoService(FeedBackCollectionDbContext context)
        {
            _context = context;
        }

        public async Task<int> Add(CommentsInfo entity)
        {
            if (entity != null)
            {
                if (entity.Likes == true)
                {
                    entity.Likes = true;
                }
                else
                {
                    entity.Dislike = true;
                }
                entity.CreatedAt = DateTime.Now;
                await _context.CommentsInfo.AddAsync(entity);
                await _context.SaveChangesAsync();
                return entity.Id;
            }

            return 0;
        }

        public async Task<int> Delete(int? id)
        {
            if (id != null)
            {
                var commentsInfo = await _context.CommentsInfo.FindAsync(id);
                _context.Remove(commentsInfo);
                await _context.SaveChangesAsync();
                return 1;
            }

            return 0;
        }

        public async Task<int> Update(CommentsInfo entity)
        {
            if (entity != null)
            {
                _context.CommentsInfo.Update(entity);
                await _context.SaveChangesAsync();
                return 1;
            }
            return 0;
        }
    }
}
