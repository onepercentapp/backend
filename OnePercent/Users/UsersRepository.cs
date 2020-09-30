using System;
using System.Threading.Tasks;
using OnePercent.Infrastructure.Data;
using OnePercent.Users.Models;

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
            return new User
            {
                Id = Guid.Parse("c1cb15eb-47fa-4c49-95ec-cd3f6410b804"),
                Created = DateTimeOffset.Now,
                Updated = DateTimeOffset.Now
            };
        }
    }
}