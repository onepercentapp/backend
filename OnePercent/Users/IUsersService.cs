using System;
using System.Threading.Tasks;

namespace OnePercent.Users
{
    public interface IUsersService
    {
        Task<User> GetAsync(Guid id);
    }
}