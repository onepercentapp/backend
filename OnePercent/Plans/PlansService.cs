using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OnePercent.Plans.Models;
using OnePercent.Users;

namespace OnePercent.Plans
{
    public class PlansService : IPlansService
    {
        private readonly IPlansRepository _plansRepository;

        private readonly IStepsRepository _stepsRepository;

        private readonly IUsersService _usersService;

        public PlansService(IPlansRepository plansRepository, IStepsRepository stepsRepository,
            IUsersService usersService)
        {
            _plansRepository = plansRepository;

            _stepsRepository = stepsRepository;

            _usersService = usersService;
        }

        public async Task<Plan> CreatePlanAsync(Guid creatorId, IReadOnlyList<Step> steps)
        {
            var user = await _usersService.GetAsync(creatorId);

            if (user is null) throw new ArgumentException("User not found");

            var plan = new Plan
            {
                CreatorId = user.Id
            };

            foreach (var step in steps)
            {
                await _stepsRepository.AddAsync(step);

                plan.Steps.Add(step);
            }

            return await _plansRepository.AddAsync(plan);
        }
    }
}