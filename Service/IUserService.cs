using FeedBackCollection.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeedBackCollection.Service
{
    public interface IUserService
    {
        Task<int> Add(UserInfo entity);
        Task<int> Delete(int? userId);
        Task<int> Update(UserInfo entity);
    }
    public class UserService : IUserService
    {
        private readonly FeedBackCollectionDbContext _context;

        public UserService(FeedBackCollectionDbContext context)
        {
            _context = context;
        }

        public async Task<int> Add(UserInfo entity)
        {
            if (entity != null)
            {
                await _context.UserInfo.AddAsync(entity);
                await _context.SaveChangesAsync();
                return entity.Id;
            }

            return 0;
        }

        public async Task<int> Delete(int? userId)
        {
            if (userId != null)
            {
                var user = await _context.UserInfo.FindAsync(userId);
                _context.Remove(user);
                await _context.SaveChangesAsync();
                return 1;
            }

            return 0;
        }

        public async Task<int> Update(UserInfo entity)
        {
            if (entity != null)
            {
                _context.UserInfo.Update(entity);
                await _context.SaveChangesAsync();
                return 1;
            }
            return 0;
        }
    }
}
