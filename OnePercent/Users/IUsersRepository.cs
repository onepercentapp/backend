using System;
using System.Threading.Tasks;
using OnePercent.Users.Models;

namespace OnePercent.Users
{
    public interface IUsersRepository
    {
        Task<User> FindAsync(Guid Id);
    }
}