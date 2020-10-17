using FeedBackCollection.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeedBackCollection.Service
{
    public interface IPostInfoService
    {
        Task<int> Add(PostInfo entity);
        Task<int> Delete(int? id);
        Task<int> Update(PostInfo entity);
    }
    public class PostInfoService : IPostInfoService
    {
        private readonly FeedBackCollectionDbContext _context;

        public PostInfoService(FeedBackCollectionDbContext context)
        {
            _context = context;
        }

        public async Task<int> Add(PostInfo entity)
        {
            if (entity != null)
            {
                entity.CreatedAt = DateTime.Now;
                await _context.PostInfo.AddAsync(entity);
                await _context.SaveChangesAsync();
                return entity.Id;
            }

            return 0;
        }

        public async Task<int> Delete(int? id)
        {
            if (id != null)
            {
                var data = await _context.PostInfo.FindAsync(id);
                _context.Remove(data);
                await _context.SaveChangesAsync();
                return 1;
            }

            return 0;
        }

        public async Task<int> Update(PostInfo entity)
        {
            if (entity != null)
            {
                _context.PostInfo.Update(entity);
                await _context.SaveChangesAsync();
                return 1;
            }
            return 0;
        }
    }
}
