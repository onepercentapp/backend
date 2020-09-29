using System;
using System.Threading.Tasks;

namespace OnePercent.Users
{
    public class UsersService : IUsersService
    {
        private readonly IUsersRepository _usersRepository;

        public UsersService(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public async Task<User> GetAsync(Guid id)
        {
            return await _usersRepository.FindAsync(id);
        }
    }
}