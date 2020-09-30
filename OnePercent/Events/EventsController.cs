using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnePercent.Events.Dto;

namespace OnePercent.Events
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class EventsController : ControllerBase
    {
        private readonly IEventsService _eventsService;

        private readonly ILogger<EventsController> _logger;

        public EventsController(IEventsService eventsService, ILogger<EventsController> logger)
        {
            _eventsService = eventsService;
            _logger = logger;
        }

        [HttpGet]
        [Route("event-series-proposal")]
        public async Task<CreateEventSeriesProposalResponse> CreateEventSeriesProposal(
            [FromBody] CreateEventSeriesProposalRequest request)
        {
            var eventSeriesProposal = await _eventsService.GetEventSeriesProposalAsync(request.Wants);

            return new CreateEventSeriesProposalResponse
            {
                Events = eventSeriesProposal
            };
        }
    }
}