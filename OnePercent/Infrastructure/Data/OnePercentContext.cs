using Microsoft.EntityFrameworkCore;
using OnePercent.Events.Models;
using OnePercent.Plans.Models;
using OnePercent.Users.Models;

namespace OnePercent.Infrastructure.Data
{
    public class OnePercentContext : DbContext
    {
        public OnePercentContext(DbContextOptions<OnePercentContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<Step> Steps { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region User

            modelBuilder.Entity<User>()
                .HasKey(u => u.Id);

            modelBuilder.Entity<User>()
                .Property(u => u.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<User>()
                .Property(u => u.Created)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<User>()
                .Property(u => u.Updated)
                .ValueGeneratedOnAddOrUpdate();

            #endregion User

            #region Event

            modelBuilder.Entity<Event>()
                .HasKey(u => u.Id);

            modelBuilder.Entity<Event>()
                .Property(u => u.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Event>()
                .Property(e => e.CreatorId)
                .IsRequired();

            modelBuilder.Entity<Event>()
                .Property(e => e.Summary)
                .IsRequired();

            modelBuilder.Entity<Event>()
                .Property(e => e.Start)
                .IsRequired();

            modelBuilder.Entity<Event>()
                .Property(e => e.End)
                .IsRequired();

            modelBuilder.Entity<Event>()
                .Property(e => e.Created)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Event>()
                .Property(e => e.Updated)
                .ValueGeneratedOnAddOrUpdate();

            #endregion Event

            #region Plan

            modelBuilder.Entity<Plan>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<Plan>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Plan>()
                .Ignore(p => p.Steps);

            modelBuilder.Entity<Plan>()
                .Property(p => p.Created)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Plan>()
                .Property(p => p.Updated)
                .ValueGeneratedOnAddOrUpdate();

            #endregion Plan

            #region Step

            modelBuilder.Entity<Step>()
                .HasKey(s => s.Id);

            modelBuilder.Entity<Step>()
                .Property(s => s.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Step>()
                .Property(s => s.Description)
                .IsRequired();

            modelBuilder.Entity<Step>()
                .Property(s => s.Created)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Step>()
                .Property(s => s.Updated)
                .ValueGeneratedOnAddOrUpdate();

            #endregion Step
        }
    }
}