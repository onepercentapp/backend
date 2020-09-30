using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OnePercent.Plans.Models;

namespace OnePercent.Plans
{
    public interface IPlansService
    {
        Task<Plan> CreatePlanAsync(Guid creatorId, IReadOnlyList<Step> steps);
    }
}