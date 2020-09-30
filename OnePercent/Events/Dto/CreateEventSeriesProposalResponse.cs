using System.Collections.Generic;
using OnePercent.Events.Models;

namespace OnePercent.Events.Dto
{
    public class CreateEventSeriesProposalResponse
    {
        public IReadOnlyList<Event> Events { get; set; }
    }
}