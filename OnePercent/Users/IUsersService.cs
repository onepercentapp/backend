using System;
using System.Threading.Tasks;
using OnePercent.Users.Models;

namespace OnePercent.Users
{
    public interface IUsersService
    {
        Task<User> GetAsync(Guid id);
    }
}