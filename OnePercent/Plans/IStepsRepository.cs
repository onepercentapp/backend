using System;
using System.Threading.Tasks;
using OnePercent.Plans.Models;

namespace OnePercent.Plans
{
    public interface IStepsRepository
    {
        Task<Step> FindAsync(Guid id);

        Task<Step> AddAsync(Step step);
    }
}