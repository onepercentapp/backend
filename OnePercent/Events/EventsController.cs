using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnePercent.Events.Dto;
using OnePercent.Events.Models;

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
        [Route("create-event-series-proposal")]
        public async Task<IEnumerable<Event>> CreateEventSeriesProposal(
            [FromBody] CreateEventSeriesProposalRequest request)
        {
            _logger.LogInformation(JsonSerializer.Serialize(request));

            return await _eventsService.CreateEventProposal(request.Wants);
        }
    }
}