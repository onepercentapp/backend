using System;
using System.Threading.Tasks;

namespace OnePercent.Users
{
    public interface IUsersRepository
    {
        Task<User> FindAsync(Guid Id);
    }
}