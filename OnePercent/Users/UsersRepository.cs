using System;
using System.Threading.Tasks;
using OnePercent.Infrastructure.Data;

namespace OnePercent.Users
{
    public class UsersRepository : IUsersRepository
    {
        private readonly OnePercentContext _dbContext;

        public UsersRepository(OnePercentContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<User> FindAsync(Guid id)
        {
            return await _dbContext.Set<User>().FindAsync(id);
        }
    }
}