using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnePercent.Plans.Dto;
using OnePercent.Plans.Models;

namespace OnePercent.Plans
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PlansController : ControllerBase
    {
        private readonly ILogger<PlansController> _logger;
        private readonly IPlansService _plansService;

        public PlansController(IPlansService plansService, ILogger<PlansController> logger)
        {
            _plansService = plansService;
            _logger = logger;
        }

        [HttpPost]
        public async Task<CreatePlanResponse> CreatePlan(
            [FromBody] CreatePlanRequest request)
        {
            var plan = await _plansService.CreatePlanAsync(request.CreatorId,
                request.Steps.Select(s => new Step {Description = s.Description}).ToList());

            return new CreatePlanResponse
            {
                Plan = plan
            };
        }
    }
}