using System;
using System.Threading.Tasks;
using OnePercent.Infrastructure.Data;
using OnePercent.Plans.Models;

namespace OnePercent.Plans
{
    public class StepsRepository : IStepsRepository
    {
        private readonly OnePercentContext _dbContext;

        public StepsRepository(OnePercentContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Step> AddAsync(Step step)
        {
            await _dbContext.Steps.AddAsync(step);

            await _dbContext.SaveChangesAsync();

            return step;
        }

        public async Task<Step> FindAsync(Guid id)
        {
            return await _dbContext.Steps.FindAsync(id);
        }
    }
}