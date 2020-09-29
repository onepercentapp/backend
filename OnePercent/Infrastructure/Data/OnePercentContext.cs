using Microsoft.EntityFrameworkCore;
using OnePercent.Events.Models;
using OnePercent.Users;

namespace OnePercent.Infrastructure.Data
{
    public class OnePercentContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }
    }
}