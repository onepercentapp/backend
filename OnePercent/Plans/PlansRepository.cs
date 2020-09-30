using System;
using System.Threading.Tasks;
using OnePercent.Infrastructure.Data;
using OnePercent.Plans.Models;

namespace OnePercent.Plans
{
    public class PlansRepository : IPlansRepository
    {
        private readonly OnePercentContext _dbContext;

        public PlansRepository(OnePercentContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Plan> FindAsync(Guid id)
        {
            return await _dbContext.Set<Plan>().FindAsync(id);
        }

        public async Task<Plan> AddAsync(Plan plan)
        {
            await _dbContext.Plans.AddAsync(plan);

            await _dbContext.SaveChangesAsync();

            return plan;
        }
    }
}