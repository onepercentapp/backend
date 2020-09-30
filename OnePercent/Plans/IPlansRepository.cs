using System;
using System.Threading.Tasks;
using OnePercent.Plans.Models;

namespace OnePercent.Plans
{
    public interface IPlansRepository
    {
        Task<Plan> FindAsync(Guid id);

        Task<Plan> AddAsync(Plan plan);
    }
}